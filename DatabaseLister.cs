using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebiGen {
	public class DatabaseLister {
		public static readonly string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=OMER\\SQLEXPRESS;TrustServerCertificate=True;";
//-----------------------------------------------------------------------------
		public List<string> GetDatabaseListUsingQuery(string connectionString) {
			List<string> databases = new List<string>();
			using (SqlConnection connection = new SqlConnection(connectionString)) {
            connection.Open();
            string query = "SELECT name FROM sys.databases";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        databases.Add(reader["name"].ToString());
                    }
                }
            }
        }
        return databases;
    }
//-----------------------------------------------------------------------------
		public List<string> GetDatabaseListUsingGetSchema(string connectionString) {
			List<string> databases = new List<string>();
			using (SqlConnection connection = new SqlConnection(connectionString)) {
				try {
					connection.Open();
					DataTable schemaTable = connection.GetSchema("databases");
					foreach (DataRow row in schemaTable.Rows) {
						databases.Add(row["database_name"].ToString());
					}
				}
				catch (Exception ex) {
					Console.WriteLine(ex.Message);
				}
			}
			return databases;
		}
	}
}
