using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace plmunAMS_user.Models
{
    public static class Connection
    {
        public static string dbname = "plmun_ams_db";
        public static string host = "192.168.100.2";
        public static string dbusername = "root";
        public static string dbpass = "12345";
        public static string sqlconn = $"Data Source={host}; Initial Catalog={dbname}; User ID={dbusername}; Password={dbpass}";

        public static int id;
        public static string user;
        public static string pass;
        public static string firstName;
    }
}
