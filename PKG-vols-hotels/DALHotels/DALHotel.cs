using static ResaVoyages.DAL.DALGeneric.DALGeneric;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ResaVoyages.DAL.DALHotels
{
    public class DALHotels
    {
        public const string SERVER_NAME = "KEPA-PC\\SQLEXPRESS";
        public const string DB_NAME = "HOTELS";
        public const string TABLE_NAME = "HOTELS";

        public DataSet GetHotels()
        {
            SqlCommand command = new SqlCommand("sp_getHotels");
            command.CommandType = CommandType.StoredProcedure;

            return CallSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);
        }

        public DataSet GetHotelById(int id)
        {
            SqlCommand command = new SqlCommand("sp_getHotelById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = id;

            return CallSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);
        }

        public DataSet GetHotelByCity(String city)
        {
            SqlCommand command = new SqlCommand("sp_getHotelByCity");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CITY", SqlDbType.VarChar, 50);
            command.Parameters["@CITY"].Value = city;

            return CallSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);
        }
    }
}
