using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PharmacyManagement
{
    class DBConnection
    {
        private static List<MySqlConnection> store = new List<MySqlConnection>();

        public static void loadStore()
        {
            for (int i = 0; i < 10; i++)
            {
                store.Add(new MySqlConnection("server = 127.0.0.1; database = pharmacy_management; username = root; password = ;"));
            }
        }

        public static MySqlConnection getConn()
        {
            MySqlConnection temp = store[0];
            store.RemoveAt(0);
            return temp;
        }

        public static void returnConn(MySqlConnection mysqlconn)
        {
            store.Add(mysqlconn);
        }
    }
}
