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
            return @"Server=DESKTOP-NI7KH0M\SQLEXPRESS;Database=consultorio;Trusted_Connection=True;";
        }
    }
}