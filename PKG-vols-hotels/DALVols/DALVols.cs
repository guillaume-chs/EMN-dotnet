using static ResaVoyages.DAL.DALGeneric.DALGeneric;
using System.Data;
using System.Data.SqlClient;
using System;

namespace ResaVoyages.DAL.DALVols
{
    public class DALVols
    {
        public const string SERVER_NAME = "(localdb)\\MSSQLLocalDB";
        public const string BD_NAME = "VOLS";
        public const string TABLE_NAME = "VOLS";
        public const string DATE_FORMAT = "yyyy'/'MM'/'dd";

        public DataSet GetVolById(int id)
        {
            SqlCommand command = new SqlCommand("sp_getVolById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@idVol", SqlDbType.Int);
            command.Parameters["@idVol"].Value = id;
            return CallSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);
        }

        public DataSet GetVols()
        {
            SqlCommand command = new SqlCommand("sp_getVols");
            command.CommandType = CommandType.StoredProcedure;
            return CallSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);

        }

        public DataSet GetVolsByDepartureDateDepartureCityArrivalCity(System.DateTime dateDeparture, string departureCity, string arrivalCity)
        {
            SqlCommand command = new SqlCommand("sp_getVolsByDepartureDateDepartureCityArrivalCity");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@departureDate", SqlDbType.DateTime);
            command.Parameters["@departureDate"].Value = dateDeparture.ToString(DATE_FORMAT);;
            command.Parameters.Add("@departureCity", SqlDbType.VarChar);
            command.Parameters["@departureCity"].Value = departureCity;
            command.Parameters.Add("@arrivalCity", SqlDbType.VarChar);
            command.Parameters["@arrivalCity"].Value = arrivalCity;

            Console.WriteLine(command.CommandText);

            return CallSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);
        }
        public DataSet DecrementVolSeatsById(int idVol, int nbSeats)
        {
            SqlCommand command = new SqlCommand("sp_decrementVolSeatsById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@idVol", SqlDbType.Int);
            command.Parameters["@idVol"].Value = idVol;
            command.Parameters.Add("@nbSeats", SqlDbType.Int);
            command.Parameters["@nbSeats"].Value = nbSeats;
            return CallSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);
        }
        public DataSet GetVolCapacityById(int idVol, int nbSeats)
        {
            SqlCommand command = new SqlCommand("sp_getVolCapacityById");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@idVol", SqlDbType.Int);
            command.Parameters["@idVol"].Value = idVol;
            return CallSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);
        }
        public DataSet AddReservationVol(String nom, String prenom, int nbPersonne, int idVol)
        {
            SqlCommand command = new SqlCommand("sp_addReservationVol");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@nom", SqlDbType.VarChar, 50);
            command.Parameters["@nom"].Value = nom;
            command.Parameters.Add("@prenom", SqlDbType.VarChar, 50);
            command.Parameters["@prenom"].Value = prenom;
            command.Parameters.Add("@nbPersonne", SqlDbType.Int);
            command.Parameters["@nbPersonne"].Value = nbPersonne;
            command.Parameters.Add("@idVol", SqlDbType.Int);
            command.Parameters["@idVol"].Value = idVol;


            return CallSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);
        }

    }
}
