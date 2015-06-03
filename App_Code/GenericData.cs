using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using SConfiguration;

namespace DataAcess
{
    
    public class GenericData
    {
        static GenericData()
        {

        }

        public static DataTable ExecuteReader(DbCommand command)
        {
            DataTable table;
            try
            {
                command.Connection.Open();
                DbDataReader reader = command.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { command.Connection.Close(); }
            return table;
        }

        public static int ExecuteNoneQuery(DbCommand command)
        {

            int AfectedRows = -1;
            try
            {
                command.Connection.Open();
                AfectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { command.Connection.Close(); }
            return AfectedRows;
        }

        public static string ExecuteScalar(DbCommand command)
        {
            string value = "";
            try
            {
                command.Connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { command.Connection.Close(); }
            return value;
        }

        public static DbCommand CreateCommand()
        {

            string dbProviderName = Configuration.DbProviderName;
            string dbConnectionString = Configuration.DbConnectionString;
            DbProviderFactory factory = DbProviderFactories.GetFactory(dbProviderName);
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = dbConnectionString;
            DbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            return command;

        }
    }
}