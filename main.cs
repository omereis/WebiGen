/*****************************************************************************\
|                                  WebiGen                                    |
|                                  main.cs                                    |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Collections;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Linq.Expressions;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
//-----------------------------------------------------------------------------
using OmerEisGlobal;
using OmerEisCommon;
//-----------------------------------------------------------------------------
namespace WebiGen {
	public partial class frmMain : Form {
		private TDBParams m_db_params;
		private static readonly string DefauleConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=OMER\\SQLEXPRESS;TrustServerCertificate=True;";
		SqlConnection m_database;
		public frmMain() {
			InitializeComponent();
			m_db_params = null;
			m_database = null;
		}
//-----------------------------------------------------------------------------
		private void miExit_Click(object sender, EventArgs e) {
			Close();
		}
//-----------------------------------------------------------------------------
		private void button1_Click(object sender, EventArgs e) {
			//string connectionString = "Server=OMER\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
			//string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=OMER\\SQLEXPRESS;TrustServerCertificate=True;";
			DatabaseLister lister = new DatabaseLister();
			List<string> databases = lister.GetDatabaseListUsingGetSchema(DefauleConnectionString);
			comboDatabases.Items.Clear();
			foreach(var db in databases) {
				comboDatabases.Items.Add(db);
				//Console.WriteLine(db);
			}
		}
//-----------------------------------------------------------------------------
		private void frmMain_Load(object sender, EventArgs e) {
			bool fConnect = false;
			string strConn = "";

			try {
				fConnect = ConnectToDB();
			} catch(Exception ex) {
				MessageBox.Show("Error connectiong to database\n" + ex.Message);
				m_database = null;
				fConnect = false;
			}
		}
//-----------------------------------------------------------------------------
		private bool ConnectToDB() {
			string strConn = LoadIniConnectionString();
			bool fConnect = false;
			try {
				if(strConn.Length > 0) {
					DisconnectDatabase ();
					m_database = new SqlConnection(strConn);
					m_database.Open();
					SetConnectButtons (true);
					fConnect = true;
				}
			} catch(Exception e) {
				fConnect = false;
				MessageBox.Show(e.Message);
			}
			UpdateStatusBar(/*strConn, fConnect*/);
			return (fConnect);
		}
//-----------------------------------------------------------------------------
		private void miDatabase_Click(object sender, EventArgs e) {
			DlgEditDB dlg = new DlgEditDB();
			string strConnection = LoadIniConnectionString();
			if(strConnection.Length == 0)
				strConnection = DefauleConnectionString;
			if(dlg.Execute(ref strConnection)) {
				SaveIniConnectionString(strConnection);
				ConnectToDB();
				txtConnection.Text = strConnection;
			}
		}
//-----------------------------------------------------------------------------
		private string LoadIniConnectionString() {
			string str = "";
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			str = ini.ReadString("Database", "default");
			return (str);
		}
//-----------------------------------------------------------------------------
		private void SaveIniConnectionString(string strConnection) {
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			ini.WriteString("Database", "default", strConnection);
		}
//-----------------------------------------------------------------------------
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
			if(m_database != null) {
				m_database.Close();
			}
		}
//-----------------------------------------------------------------------------
		private void UpdateStatusBar(/*string strConnection, bool fConnect*/) {
			//TMsSqlDbParams ms_params = new TMsSqlDbParams(strConnection);
			string strServer = "", strDatabase = "";
			bool fConnect = false;
			if(m_database != null) {
				strServer = m_database.DataSource;
				strDatabase = m_database.Database;
				fConnect = m_database.State == ConnectionState.Open;
			}
			//string strServer = ms_params.GetServer();
			//string strDatabase = ms_params.GetDatabase ();
			status_bar.Items[0].Text = System.String.Format("Server={0}", strServer);
			status_bar.Items[1].Text = System.String.Format("Database={0}", strDatabase);
			status_bar.Items[2].Text = (fConnect ? "Connected" : "Disconnected");
		}
//-----------------------------------------------------------------------------
		private void btnConnect_Click(object sender, EventArgs e) {
			ConnectToDB ();
			SetConnectButtons (true);
		}
//-----------------------------------------------------------------------------
		private void btnDisconnect_Click(object sender, EventArgs e) {
			DisconnectDatabase ();
			SetConnectButtons (false);
			UpdateStatusBar();
		}
//-----------------------------------------------------------------------------
		private void DisconnectDatabase () {
			if (m_database != null)
				if (m_database.State == ConnectionState.Open)
					m_database.Close ();
		}
//-----------------------------------------------------------------------------
		private void SetConnectButtons (bool fConnect) {
			btnConnect.Enabled = !fConnect;
			btnDisconnect.Enabled = fConnect;
		}
	}
//-----------------------------------------------------------------------------
}
