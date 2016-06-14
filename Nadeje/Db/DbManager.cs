using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadeje.Db
{
	public static class DbManager
	{
		public static bool Insert(string connectionstring, string dbName, string user, string psw, string role)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionstring))
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = $"INSERT INTO {dbName} (username, userpsw, role) VALUES (@username, @userpsw, @role)";
					command.Parameters.AddWithValue("@username", user);
					command.Parameters.AddWithValue("@userpsw", psw);
					command.Parameters.AddWithValue("@role", role);
            
          connection.Open();
					command.ExecuteNonQuery();
					return true;
				}
			}
			catch (SqlException ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
	}
}
