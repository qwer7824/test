using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace test.DBConn
{
    class DBConn
    {
        private static string DBIP = Properties.Settings.Default.DBIP;
        private static int DBPORT = Properties.Settings.Default.DBPORT;
        private static string DB = Properties.Settings.Default.DB;
        private static string DBID = Properties.Settings.Default.DBID;
        private static string DBPW = Properties.Settings.Default.DBPW;
        private static MySqlConnection conn = null;

        public static MySqlConnection getConn()
        {
            string connString = "Server=" + DBIP
                                 + ";Port=" + DBPORT
                                  + ";Database=" + DB
                                  + ";Uid=" + DBID
                                    + ";Pwd=" + DBPW;

            conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
