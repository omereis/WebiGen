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
		public frmMain() {
			InitializeComponent();
			m_db_params = null;
		}
//-----------------------------------------------------------------------------
		private void miExit_Click(object sender, EventArgs e) {
			Close();
		}

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
			if(m_db_params == null) {
				m_db_params = new TDBParams();
				m_db_params.LoadFromINI(TMisc.GetIniName());
			}
		}
//-----------------------------------------------------------------------------
		private void miDatabase_Click(object sender, EventArgs e) {
			DlgEditDB dlg = new DlgEditDB();
			string strConnection = LoadIniConnectionString ();
			if (strConnection.Length == 0)
				strConnection = DefauleConnectionString;
			if (dlg.Execute (ref strConnection)) {
				SaveIniConnectionString (strConnection);
				txtConnection.Text = strConnection;
			}
		}
//-----------------------------------------------------------------------------
		private string LoadIniConnectionString () {
			string str="";
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			str = ini.ReadString ("Database", "default");
			return (str);
		}
//-----------------------------------------------------------------------------
		private void SaveIniConnectionString (string strConnection) {
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			ini.WriteString("Database", "default", strConnection);
		}
	}
//-----------------------------------------------------------------------------
}
