using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SConfiguration
{
    /// <summary>
    /// Summary description for Configuration
    /// </summary>
    public class Configuration
    {
        private static string dbConnectionString;
        private static string dbProviderName;
        static Configuration()
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            dbProviderName = ConfigurationManager.ConnectionStrings["ConnectionString"].ProviderName;

        }
        public static string DbConnectionString
        {
            get { return dbConnectionString; }
        }

        public static string DbProviderName
        {
            get { return dbProviderName; }
        }
    }
}