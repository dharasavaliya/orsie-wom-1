using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DBL
{
    public class Lookups
    {
        public static string GetConnString()
        {
            //return Configuration.GetConnectionString("DefaultConnection");
            return "Data Source=localhost;Initial Catalog=WOM_SalesCoach;Integrated Security=True;";
        }
    }

}