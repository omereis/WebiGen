using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebiGen {
	public class TMsSqlDbParams {
		private string m_strConnection;
		private string strServer;
		private string m_strDatabase;
		//private string[] m_astrParams;
		List<string[]> m_lstParams;
//-----------------------------------------------------------------------------
		public TMsSqlDbParams () {
			m_lstParams = null;
		}
//-----------------------------------------------------------------------------
		public TMsSqlDbParams (string strConnection) {
			string[] astrParams = strConnection.Split(";"), astr;
			m_lstParams = new List<string[]>();
			for (int n=0 ; n < astrParams.Length ; n++) {
				astr = (string[]) astrParams[n].Split("=").Clone();
				if (astr.Length > 0 )
					if (astr[0].Length > 0)
						m_lstParams.Add(astr);
			}
		}
		public static string GetServerConnectionString (string strServer) {
			string str = String.Format ("Integrated Security=SSPI;server={0};TrustServerCertificate=True;", strServer);
			return (str);
		}
//-----------------------------------------------------------------------------
		public static string GetServerConnectionString (string strServer, string strDatabase) {
			string str = String.Format ("Integrated Security=SSPI;server={0};TrustServerCertificate=True;", strServer);
			str += String.Format ("Database={0}", strDatabase);
			return (str);
		}
//-----------------------------------------------------------------------------
		public static bool LoadServerDatabases (string strServer, List<string> list) {
			string strConn = TMsSqlDbParams.GetServerConnectionString (strServer);
			SqlConnection conn = null;
			bool fLoad;

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
				fLoad = true;

			}
			catch (Exception ex) {
				MessageBox.Show (ex.Message);
				fLoad = false;
			}
			finally {
				if (conn != null)
					conn.Close ();
			}
			return (fLoad);
		}
//-----------------------------------------------------------------------------
		public string GetServer() {
			string strServer = FindValue ("Data Source");
			if (strServer.Length == 0)
				strServer = FindValue ("server");
			return (strServer);
		}
//-----------------------------------------------------------------------------
		private string FindValue (string strKey) {
			int n;
			string strValue="";
			if (m_lstParams != null) {
				for (n=0 ; (n < m_lstParams.Count) && (strValue.Length == 0) ; n++) {
					string[] astr = m_lstParams[n];
					if (String.Compare (astr[0], strKey, true) == 0)
						strValue = astr[1];
				}
			}
			return (strValue);
		}
//-----------------------------------------------------------------------------
		public string GetDatabase () {
			string strDatabase = FindValue ("Database");
			if (strDatabase.Length == 0)
				strDatabase = FindValue ("Initial Catalog");
			return (strDatabase);
		}
	}
}
