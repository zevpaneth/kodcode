using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attendance
{
    internal class DBConnection
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-N26DVKE\\SQLSERVER1;initial catalog=Attendance; user id=sa; password=1234;TrustServerCertificate=Yes";

        public static bool Connect()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static string runSQL(string sql, string[] parameters, string[] values)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                    // Add parameters
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameters[i], values[i]);
                    }
                    return cmd.ExecuteScalar()?.ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return "";
        }
    }
}