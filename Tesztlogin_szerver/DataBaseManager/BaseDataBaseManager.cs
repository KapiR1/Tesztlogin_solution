using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tesztlogin_szerver.DataBaseManager
{
    public class BaseDataBaseManager
    {
        protected BaseDataBaseManager() { }
        public static MySqlConnection Connection
        {
            get
            {
                MySqlConnection connection = new MySqlConnection()
                {
                    ConnectionString = "SERVER=localhost;DATABASE=órai;UID=root;PASSWORD=;SSL MODE=none"

                };
                return connection;
            }
        }
    }
}