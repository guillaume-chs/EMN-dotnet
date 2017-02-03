﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DalGeneric;

namespace DALVols
{
    public class Vols
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
            return Generic.callSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);
        }

        public DataSet GetVols()
        {
            SqlCommand command = new SqlCommand("sp_getVols");
            command.CommandType = CommandType.StoredProcedure;
            return Generic.callSP(command, SERVER_NAME, BD_NAME, TABLE_NAME);

        }
    }
}
