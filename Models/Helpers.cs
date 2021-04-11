using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MummyMadness.Models
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["mummygummy"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["postgres"];
            string password = appConfig["MummyIntexRox!312"];
            string hostname = appConfig["mummygummy.cuy6cls8yekj.us-east-1.rds.amazonaws.com"];
            string port = appConfig["5432"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}