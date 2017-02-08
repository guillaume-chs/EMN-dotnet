using System;
using System.Data;
using System.Data.SqlClient;

namespace ResaVoyages.DAL.DALGeneric
{
    public class DALGeneric
    {
        public const string SERVER_NAME = "KEPA-PC\\SQLEXPRESS";
        public static DataSet CallSP(SqlCommand command, String serverName, String dbName, String tableName)
        {
            DataSet result = new DataSet();

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=" + serverName + ";Initial Catalog=" + dbName + ";Integrated Security = true";
                connection.Open();

                command.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;

                sda.Fill(result, tableName);

                sda.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}
