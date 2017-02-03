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
        String TABLE_NAME = "HOTELS";
        String DB_NAME = "(localdb)";
        public DataSet GetHotels()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=" + DB_NAME + ";Initial Catalog=" + TABLE_NAME + ";Integrated Security = true";
            connection.Open();

            SqlCommand command = new SqlCommand("sp_getHotels", connection);
            command.CommandType = CommandType.StoredProcedure;

            DataSet result = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;

            sda.Fill(result, TABLE_NAME);

            sda.Dispose();
            command.Dispose();
            connection.Close();

            return result;
        }
        public DataSet GetHotelById(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=" + DB_NAME + ";Initial Catalog=" + TABLE_NAME + ";Integrated Security = true";
            connection.Open();

            SqlCommand command = new SqlCommand("sp_getHotelById", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ID", SqlDbType.Int, sizeof(int));
            command.Parameters["@ID"].Value = id;
            DataSet result = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;

            sda.Fill(result, TABLE_NAME);

            sda.Dispose();
            command.Dispose();
            connection.Close();

            return result;
        }
        public DataSet GetHotelByCity(String city)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=" + DB_NAME + ";Initial Catalog=" + TABLE_NAME + ";Integrated Security = true";
            connection.Open();

            SqlCommand command = new SqlCommand("sp_getHotelByCity", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@CITY", SqlDbType.VarChar, 50);
            command.Parameters["@CITY"].Value = city;
            DataSet result = new DataSet();

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;

            sda.Fill(result, TABLE_NAME);

            sda.Dispose();
            command.Dispose();
            connection.Close();

            return result;
        }
    }

}
