/*****************************************************************************\
|                                  WebiGen                                    |
|                             EditImportCsv.cs                                |
\*****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

//-----------------------------------------------------------------------------
using OmerEisCommon;
namespace WebiGen {
	public partial class DlgImportCsv : Form {
		private SqlConnection m_database;
		SqlCommand m_cmd;
		private string m_strErr;
		public DlgImportCsv() {
			InitializeComponent();
			m_cmd = null;
		}
		//-----------------------------------------------------------------------------
		private void btnRefresh_Click(object sender, EventArgs e) {
			ReadFromCsv();
		}
		//-----------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
		//-----------------------------------------------------------------------------
		public bool Execute(SqlCommand cmd, string strFile) {
			//Download(database, strFile);
			Download(cmd, strFile);
			bool f = ShowDialog() == DialogResult.OK;
			return (f);
		}
		//-----------------------------------------------------------------------------
		//private void Download(SqlConnection database, string strFile) {
		private void Download(SqlCommand cmd, string strFile) {
			m_database = null;//database;
			m_cmd = cmd;
			txtFile.Text = strFile;
			ReadFromCsv();
		}
		//-----------------------------------------------------------------------------
		private void ReadFromCsv() {
			TPointInfo[] aPoints;
			string[] astrFile = TMisc.ReadFile(txtFile.Text);
			if(astrFile != null)
				if((aPoints = TPointInfo.ReadFromCsv(astrFile)) != null)
					Download(aPoints);
		}
		//-----------------------------------------------------------------------------
		private void Download(TPointInfo[] aPoints) {
			gridStats.Rows.Clear();
			if(aPoints != null) {
				gridStats.RowCount = aPoints.Length;
				for(int n = 0; n < aPoints.Length; n++)
					SetGridRow(n, aPoints[n]);
			}
		}
		//-----------------------------------------------------------------------------
		private void SetGridRow(int row, TPointInfo point) {
			double dMin, dMax, dAvg, dStd;

			try {
				dMin = dMax = dAvg = dStd = 0;
				TRadValue.GetStats(point.Radiations, ref dMin, ref dMax, ref dAvg, ref dStd);
				gridStats.Rows[row].Cells[0].Tag = point;
				gridStats.Rows[row].Cells[0].Value = point.Name;
				gridStats.Rows[row].Cells[1].Value = TMisc.AppDateTime(point.Radiations[0].SampleTime);
				gridStats.Rows[row].Cells[2].Value = TMisc.AppDateTime(point.Radiations[point.Radiations.Length - 1].SampleTime);
				gridStats.Rows[row].Cells[3].Value = TMisc.IntFormat(point.Radiations.Length);
				DateTime? dt = TPointInfo.GetSamplingRate(point.Radiations);
				if(dt != null)
					gridStats.Rows[row].Cells[4].Value = System.String.Format("{0}.{1:D3}", dt.Value.Second, dt.Value.Millisecond);
				gridStats.Rows[row].Cells[6].Value = (1e3 * dMin).ToString("0.##");
				gridStats.Rows[row].Cells[7].Value = (1e3 * dMax).ToString("0.##");
				gridStats.Rows[row].Cells[8].Value = (1e3 * dAvg).ToString("0.##");
				gridStats.Rows[row].Cells[9].Value = (1e3 * dStd).ToString("0.##");
			} catch(Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
		//-----------------------------------------------------------------------------
		private void cboxDeleteCurrent_CheckedChanged(object sender, EventArgs e) {
			if(cboxDeleteCurrent.Checked) {
				if(MessageBox.Show("Delete all current radiation data?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
					cboxDeleteCurrent.Checked = false;
			}
		}
		//-----------------------------------------------------------------------------
		private TPointInfo[] UploadGridPoints() {
			TPointInfo[] aPoints = null;
			ArrayList alPoints = new ArrayList();

			for (int n=0 ; n < gridStats.Rows.Count ; n++) {
				try {
					alPoints.Add ((TPointInfo) gridStats.Rows[n].Cells[0].Tag);
				}
				catch {
				}
			}
			if (alPoints.Count > 0 )
				aPoints = TPointInfo.ToArray (alPoints);
			return (aPoints);
		}
		//-----------------------------------------------------------------------------
		private void btnInsert_Click(object sender, EventArgs e) {
			System.Windows.Forms.Cursor curOld = System.Windows.Forms.Cursor.Current;
			int nInserted=0;
			try {
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
				TPointInfo[] aPoints = UploadGridPoints();
				for (int n=0 ; n < aPoints.Length ; n++) {
					//if (!aPoints[n].InsertToDB (m_database, cboxDeleteCurrent.Checked, cboxOverride.Checked, ref m_strErr))
					if (aPoints[n].InsertToDB (m_cmd, cboxDeleteCurrent.Checked, cboxOverride.Checked, ref m_strErr, ref nInserted))
						MessageBox.Show(TMisc.IntFormat (nInserted)  + " records inserted");
					else
						MessageBox.Show (m_strErr);
				}
			}
			catch (Exception ex) {
				MessageBox.Show (ex.ToString ());
			}
			finally {
				System.Windows.Forms.Cursor.Current = curOld;
			}
		}
	}
}
