/*****************************************************************************\
|                                  WebiGen                                    |
|                              EditAddPoint.cs                                |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------------------------------------------
using Microsoft.Data.SqlClient;
using OmerEisCommon;
namespace WebiGen {
	public partial class DlgAddPoint : Form {
		private SqlCommand m_cmd;
		private SqlTransaction m_trns = null;
		SqlConnection m_database;
		private string m_strErr="";
		public DlgAddPoint() {
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
//-----------------------------------------------------------------------------
		public bool Execute (SqlConnection database, TPointInfo point) {
			m_database = database;
			//m_cmd = database.CreateCommand();
			//m_trns = database.BeginTransaction();
			Download (point);
			bool f = ShowDialog() == DialogResult.OK;
//			if (f)
//				m_trns.Commit();
//			else
//				m_trns.Rollback();
			return (f);
		}
//-----------------------------------------------------------------------------
		private void Download (TPointInfo point) {
			TRadValue[] aRads = new TRadValue[3];
			if (TRadValue.LoadFromDB (m_database, point.PointID, ref aRads, ref m_strErr)) {
				Tag = point;
				txtName.Text = point.Name;
				txtFrom.Text = TMisc.AppTime(aRads[0].SampleTime);
				txtTo.Text = TMisc.AppTime(aRads[aRads.Length - 1].SampleTime);
				txtCount.Text = TMisc.IntFormat(aRads.Length);
				DateTime? dt = TPointInfo.GetSamplingRate(aRads);
				if (dt != null)
					txtRate.Text = System.String.Format("{0}.{1:D3}", dt.Value.Second, dt.Value.Millisecond);
				DownloadStats (aRads);
			}
			else
				MessageBox.Show(m_strErr);
		}
//-----------------------------------------------------------------------------
		private void DownloadStats (TRadValue[] aRads) {
			double dMin, dMax, dAvg, dStd;
			
			dMin = dMax = dAvg = dStd = 0;
			TRadValue.GetStats (aRads, ref dMin, ref dMax, ref dAvg, ref dStd);
			txtMin.Text = (dMin * 1e3).ToString("N3");
			txtMax.Text = (dMax * 1e3).ToString("N3");
			txtAverage.Text = (dAvg * 1e3).ToString("N3");
			txtStdDiv.Text = (dStd * 1e3).ToString("N3");
		}
	}
}
