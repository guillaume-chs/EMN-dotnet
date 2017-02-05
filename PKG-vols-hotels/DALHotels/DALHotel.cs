using static ResaVoyages.DAL.DALGeneric.DALGeneric;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ResaVoyages.DAL.DALHotels
{
    public class DALHotels
    {
        public const string SERVER_NAME = "(localdb)\\MSSQLLocalDB";
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
        public DataSet DecrementHotelSeatsById(int idHotel, int nbSeats)
        {
            SqlCommand command = new SqlCommand("sp_decrementHotelRoomsById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@idHotel", SqlDbType.Int);
            command.Parameters["@idHotel"].Value = idHotel;
            command.Parameters.Add("@nbRooms", SqlDbType.Int);
            command.Parameters["@nbRooms"].Value = nbSeats;
            return CallSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);
        }
        public DataSet GetHotelCapacityById(int idHotel, int nbSeats)
        {
            SqlCommand command = new SqlCommand("sp_getHotelCapacityById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@idHotel", SqlDbType.Int);
            command.Parameters["@idHotel"].Value = idHotel;
            return CallSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);
        }

        public DataSet InsertReservationHotel(String nom, String prenom, int nbPersonne, int idHotel)
        {
            SqlCommand command = new SqlCommand("sp_addReservationHotel");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@nom", SqlDbType.VarChar, 50);
            command.Parameters["@nom"].Value = nom;
            command.Parameters.Add("@prenom", SqlDbType.VarChar, 50);
            command.Parameters["@prenom"].Value = prenom;
            command.Parameters.Add("@nbPersonne", SqlDbType.Int);
            command.Parameters["@nbPersonne"].Value = nbPersonne;
            command.Parameters.Add("@idHotel", SqlDbType.Int);
            command.Parameters["@idHotel"].Value = idHotel;


            return CallSP(command, SERVER_NAME, DB_NAME, TABLE_NAME);
        }

    }
}
