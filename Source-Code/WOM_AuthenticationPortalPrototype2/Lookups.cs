using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Tables
{
    public class Lookups
    {
        static IConfiguration Configuration;
        public static String GetConnString()
        {
            return Configuration.GetConnectionString("DefaultConnection");
        }
    }
}
