using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Configurations
{
    public class SQLServer
    {
        public static string getConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["consultorio"].ConnectionString;
        }
    }
}