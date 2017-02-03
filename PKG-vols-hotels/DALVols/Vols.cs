using System;
using System.Data;
using System.Data.SqlClient;

namespace ResaVoyages.DALVols
{
    public class Vols
    {
        public const string SERVER_NAME = "PAUL\\SQLEXPRESS";
        public const string BD_NAME = "VOLS";
        public const string TABLE_NAME = "VOLS";

        private DataSet callSP(SqlCommand command)
        {
            DataSet result = new DataSet();

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=" + SERVER_NAME + ";Initial Catalog=" + BD_NAME + ";Integrated Security = true";
                connection.Open();

                command.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;

                sda.Fill(result, TABLE_NAME);

                sda.Dispose();
                command.Dispose();
                connection.Close();
            } catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }

        public DataSet GetVolById(int id)
        {
            SqlCommand command = new SqlCommand("sp_getVolById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@idVol", SqlDbType.Int);
            command.Parameters["@idVol"].Value = id;

            return callSP(command);
        }

        public DataSet GetVols()
        {
            SqlCommand command = new SqlCommand("sp_getVols");
            command.CommandType = CommandType.StoredProcedure;

            return callSP(command);
        }
    }
}
