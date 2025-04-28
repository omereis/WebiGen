using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebiGen {
	public class TMsSqlDbParams {
		private string m_strConnection;
		private string strServer;
		private string m_strDatabase;
		public static string GetServerConnectionString (string strServer) {
			string str = String.Format ("Integrated Security=SSPI;server={0};TrustServerCertificate=True;", strServer);
			return (str);
		}
	}
}
