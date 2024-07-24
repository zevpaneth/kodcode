using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ShabbatMealPlanner
{
    internal class DBConnection
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-N26DVKE\\SQLSERVER1;initial catalog=College; user id=sa; password=1234;TrustServerCertificate=Yes";

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


        public static string runSQL(string sql, string[] parameters, object[] values)
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


                    cmd.ExecuteNonQuery();
                    return string.Empty;


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
            return "failed";
        }

        public static SqlDataReader runSQL2(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;

                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }

                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }

            }
            return null;
        }

        public static DataTable RunSQLTable(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;

                    if(parameters != null && values != null)
                    {
                        for(int i = 0;i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }

                        
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (SqlException ex) { }
            }
            return null;
        }
    }
}