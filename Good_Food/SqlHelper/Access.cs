using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Food.SqlHelper
{
     class Access
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public static string GetMeniuPath()
        {
            return ConfigurationManager.AppSettings["Meniu"];
        }

        public static string GetExcelPath()
        {
            return ConfigurationManager.AppSettings["MeniuExcel"];
        }

    }
}
