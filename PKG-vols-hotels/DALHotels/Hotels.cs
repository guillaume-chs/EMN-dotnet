using DalGeneric;
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
        
        public DataSet GetHotels()
        {
            SqlCommand command = new SqlCommand("sp_getHotels");
            command.CommandType = CommandType.StoredProcedure;

            return Generic.callSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);

        }
        public DataSet GetHotelById(int id)
        {
            SqlCommand command = new SqlCommand("sp_getHotelById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = id;
            return Generic.callSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);

        }
        public DataSet GetHotelByCity(String city)
        {
            SqlCommand command = new SqlCommand("sp_getHotelByCity");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@CITY", SqlDbType.VarChar, 50);
            command.Parameters["@CITY"].Value = city;
            return Generic.callSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);
            
        }
    }

}
