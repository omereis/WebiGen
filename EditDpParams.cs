/*****************************************************************************\
|                                  WebiGen                                    |
|                              EditDpParams.cs                                |
\*****************************************************************************/
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------------------------------------------------------------------------
namespace WebiGen {
	public partial class DlgEditDB : Form {
//-----------------------------------------------------------------------------
		public DlgEditDB() {
			InitializeComponent();
		}
//-----------------------------------------------------------------------------
		private void btnOK_Click(object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
		}
//-----------------------------------------------------------------------------
		public bool Execute(ref string strConnection) {
			Download(strConnection);
			bool f = ShowDialog() == DialogResult.OK;
			if(f)
				Upload(ref strConnection);
			return (f);
		}
//-----------------------------------------------------------------------------
		private void Download(string strConnection) {
			int n;
			txtConnection.Text = strConnection;
			string[] astrParams = strConnection.Split(';');
			gridDetails.Rows.Clear();
			for (n=0 ; n < astrParams.Length ; n++) {
				if (astrParams[n].Length > 0) {
					string[] astr = astrParams[n].Split("=");
					if (astr.Length > 1) {
						int row = gridDetails.Rows.Add();
						gridDetails.Rows[row].Cells[0].Value = astr[0];
						gridDetails.Rows[row].Cells[1].Value = astr[1];
					}
				}
			}
			string strServer = FindValue ("Data Source");
			comboDatabase.Items.Clear();
			if (strServer != null) {
				txtServer.Text = strServer;
				List<string> list = new List<string>();
				LoadAllDatabases (strServer, list);
				if (list.Count > 0) {
					for (n=0 ; n < list.Count ; n++) {
						comboDatabase.Items.Add (list[n]);
					}
					comboDatabase.Items.Insert (0, "");
				}
			}
			string strDatabase = FindValue ("Initial Catalog");
			if (strDatabase.Length > 0) {
				int idx = comboDatabase.Items.IndexOf (strDatabase);
				if (idx >= 0)
					comboDatabase.SelectedIndex = idx;
			}
		}
//-----------------------------------------------------------------------------
		private void Upload(ref string strConnection) {
			Compose();
			strConnection = txtConnection.Text;
		}
//-----------------------------------------------------------------------------
		private void Compose() {
		}
//-----------------------------------------------------------------------------
		private void btnTest_Click(object sender, EventArgs e) {
			string strConn = txtConnection.Text.Trim();
			SqlConnection conn = null;

			try {
				conn = new SqlConnection(strConn);
				conn.Open();
				MessageBox.Show ("Connection OK");
			}
			catch (Exception ex) {
				MessageBox.Show ("Connection Error\n" + ex.Message);
			}
			finally {
				if (conn != null) {
					conn.Close();
					conn.Dispose();
				}
			}
		}
//-----------------------------------------------------------------------------
		private string FindValue (string strKey) {
			string strValue="";
			int nFound=-1;
			for (int n=0 ; (n < gridDetails.Rows.Count) && (nFound < 0) ; n++) {
				if (gridDetails.Rows[n].Cells[0].Value.ToString() == strKey)
					nFound = n;
			}
			if (nFound >= 0)
				strValue = gridDetails.Rows[nFound].Cells[1].Value.ToString();
			return (strValue);
		}
//-----------------------------------------------------------------------------
		private void LoadAllDatabases (string strServer, List<string> list) {
			string strConn = TMsSqlDbParams.GetServerConnectionString (strServer);
			SqlConnection conn = null;
			SqlDataReader reader = null;

			try {
				conn = new SqlConnection (strConn);
				conn.Open();
				using (SqlCommand cmd = new SqlCommand ("SELECT name FROM master.sys.databases;", conn)) {
					using (IDataReader dr = cmd.ExecuteReader()) {
						while (dr.Read()) {
							list.Add(dr[0].ToString());
						}
					}
				}

			}
			catch (Exception ex) {
				MessageBox.Show (ex.Message);
			}
			finally {
				if (conn != null)
					conn.Close ();
			}
		}
	}
}
