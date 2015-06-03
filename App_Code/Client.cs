using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using DataAcess;

namespace SClient
{
    public class Client
    {
        public static DataTable GetClients()
        {
            DbCommand command = GenericData.CreateCommand();
            command.CommandText = "sp_getProduct";
            return GenericData.ExecuteReader(command);
        }
    }
}
