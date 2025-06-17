/*****************************************************************************\
|                                  WebiGen                                    |
|                              EditAddPoint.cs                                |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

//-----------------------------------------------------------------------------
using Microsoft.Data.SqlClient;
using OmerEisCommon;
namespace WebiGen {
	public partial class DlgAddPoint : Form {
		private SqlCommand m_cmd;
		private SqlTransaction m_trns = null;
		SqlConnection m_database;
		private string m_strErr = "";
		private TPointInfo m_point;
		public DlgAddPoint() {
			InitializeComponent();
			chartRate.Series.Clear();
		}

		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
		//----------------------------------------------------------------------------
		public bool Execute(SqlConnection database, TPointInfo point, ref TRadAdd ra) {
			m_database = database;
			m_point = point;
			//m_cmd = database.CreateCommand();
			//m_trns = database.BeginTransaction();
			Download(point);
			bool f = ShowDialog() == DialogResult.OK;
			if(f)
				Upload(ref ra);
			return (f);
		}
		//----------------------------------------------------------------------------
		private void Download(TPointInfo point) {
			TRadValue[] aRads = new TRadValue[3];

			if(TRadValue.LoadFromDB(m_database, point.PointID, ref aRads, ref m_strErr)) {
				Tag = point;
				txtName.Text = point.Name;
				txtFrom.Text = TMisc.AppDateTime(aRads[0].SampleTime);
				txtFrom.Tag = aRads[0].SampleTime;
				txtTo.Text = TMisc.AppDateTime(aRads[aRads.Length - 1].SampleTime);
				txtCount.Text = TMisc.IntFormat(aRads.Length);
				DateTime? dt = TPointInfo.GetSamplingRate(aRads);
				if(dt != null)
					txtRate.Text = System.String.Format("{0}.{1:D3}", dt.Value.Second, dt.Value.Millisecond);
				DownloadStats(aRads);
				SetToStart();
			} else
				MessageBox.Show(m_strErr);
		}
		//----------------------------------------------------------------------------
		private void Upload(ref TRadAdd raDest) {
			TRadAdd ra = new TRadAdd();
			ra.Start = dtpStartDate.Value;
			ra.End = dtpEndDate.Value;
			ra.SamplingRate = TMisc.ToDoubleDef(txtRate.Text);
			ra.Min = TMisc.ToDoubleDef(txtMin.Text);
			ra.Max = TMisc.ToDoubleDef(txtMax.Text);
			ra.Average = TMisc.ToDoubleDef(txtAverage.Text);
			ra.StdDev = TMisc.ToDoubleDef(txtStdDiv.Text);
			if(ra.IsValid())
				raDest = new TRadAdd(ra);
		}
		//----------------------------------------------------------------------------
		private TimeSpan? UploadSamplingRate() {
			TimeSpan? ts = null;

			double dRate = TMisc.ToDoubleDef(txtRate.Text);
			if(dRate > 0) {
				ts = TimeSpan.FromSeconds(dRate);
			}
			return (ts);
		}
		//----------------------------------------------------------------------------
		private void DownloadStats(TRadValue[] aRads) {
			double dMin, dMax, dAvg, dStd;

			dMin = dMax = dAvg = dStd = 0;
			TRadValue.GetStats(aRads, ref dMin, ref dMax, ref dAvg, ref dStd);
			txtMin.Text = (dMin * 1e3).ToString("N3");
			txtMax.Text = (dMax * 1e3).ToString("N3");
			txtAverage.Text = (dAvg * 1e3).ToString("N3");
			txtStdDiv.Text = (dStd * 1e3).ToString("N3");
		}
		//----------------------------------------------------------------------------
		private void btnSetToEnd_Click(object sender, EventArgs e) {
			SetToStart();
		}
		//----------------------------------------------------------------------------
		private void SetToStart() {
			TRadValue rad = null;

			if(m_point.LoadStartRad(m_database, ref rad, ref m_strErr)) {
				TimeSpan? ts = UploadSamplingRate();
				if((rad != null) && (ts != null)) {
					DateTime dtEnd = rad.SampleTime.Value.Subtract(ts.Value);
					dtpEndDate.Value = dtEnd;
					dtpStartDate.Value = dtEnd;
				}
			}
		}
		//----------------------------------------------------------------------------
		private void btnCalculateCount_Click(object sender, EventArgs e) {
			DateTime dtEnd = dtpEndDate.Value;
			DateTime dtStart = dtpStartDate.Value;
			TimeSpan ts = dtEnd - dtStart;
			long nCount = (long)(ts.TotalSeconds + 0.5);
			double dSamplingRate = TMisc.ToDoubleDef(txtRate.Text);
			if(dSamplingRate > 0)
				txtAddCount.Text = String.Format("{0:#,0}", nCount / dSamplingRate);
			else
				txtAddCount.Text = String.Format("Illegal sampling rate: {0}", dSamplingRate);
		}
		//----------------------------------------------------------------------------
		private void btnCalculateStart_Click(object sender, EventArgs e) {
			DateTime dtEnd = dtpEndDate.Value;
			string str = txtAddCount.Text;
			int idx;
			if(str.Length > 0) {
				while((idx = str.IndexOf(",")) >= 0)
					str = str.Remove(idx, 1);
				int nCount = TMisc.ToIntDef(str);
				double dSamplingRate = TMisc.ToDoubleDef(txtRate.Text);
				if(dSamplingRate > 0) {
					ulong nTotalCount = (ulong)(nCount * dSamplingRate);
					TimeSpan ts = TimeSpan.FromSeconds(nTotalCount);
					DateTime dtStart = dtEnd.Subtract(ts);
					dtpStartDate.Value = dtStart;
				}
			}
		}

		private void Draw_Click(object sender, EventArgs e) {
			TRadValue[] aRads = null;
			chartRate.Series.Clear();
			if (m_point.LoadRadiations (m_database, ref aRads, ref m_strErr)) {
				if (aRads != null) {
					Series ser = new Series();
					ser.ChartType = SeriesChartType.Line;
					ser.XValueType = ChartValueType.DateTime;
					for (int n=0 ; n < aRads.Length ; n++)
						//ser.Points.AddXY (n, aRads[n].Rate);
						ser.Points.AddXY (aRads[n].SampleTime, aRads[n].Rate);
					chartRate.Series.Add(ser);
				}
			}
		}
		//----------------------------------------------------------------------------
	}
}
