using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALHotels
{
    public class Hotels
    {
        public const string SERVER_NAME = "KEPA-PC\\SQLEXPRESS";
        public const string DB_NAME = "HOTELS";
        public const string TABLE_NAME = "HOTELS";
        private DataSet callSP(SqlCommand command)
        {
            DataSet result = new DataSet();

            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=" + SERVER_NAME + ";Initial Catalog=" + DB_NAME + ";Integrated Security = true";
                connection.Open();

                command.Connection = connection;

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;

                sda.Fill(result, TABLE_NAME);

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

        public DataSet GetHotels()
        {
            SqlCommand command = new SqlCommand("sp_getHotels");
            command.CommandType = CommandType.StoredProcedure;

            return callSP(command);

        }
        public DataSet GetHotelById(int id)
        {
            SqlCommand command = new SqlCommand("sp_getHotelById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = id;

            return callSP(command);
        }
        public DataSet GetHotelByCity(String city)
        {
            SqlCommand command = new SqlCommand("sp_getHotelByCity");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CITY", SqlDbType.VarChar, 50);
            command.Parameters["@CITY"].Value = city;
            return callSP(command);
            
        }
    }

}
