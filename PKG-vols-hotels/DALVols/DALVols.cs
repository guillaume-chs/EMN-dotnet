using static ResaVoyages.DAL.DALGeneric.DALGeneric;
using System.Data;
using System.Data.SqlClient;

namespace ResaVoyages.DAL.DALVols
{
    public class DALVols
    {
        public const string SERVER_NAME = "PAUL\\SQLEXPRESS";
        public const string BD_NAME = "VOLS";
        public const string TABLE_NAME = "VOLS";

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
    }
}
