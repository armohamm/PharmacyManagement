using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PharmacyManagement.InventoryManagement
{
    class DBConnection
    {
        private static Queue<MySqlConnection> queue = new Queue<MySqlConnection>();

        public static void loadQueue()
        {
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(new MySqlConnection("server = 127.0.0.1; database = pharmacy_management; username = root; password = ;"));
            }
        }

        public static MySqlConnection getConn()
        {
            return queue.Dequeue();
        }

        public static void returnConn(MySqlConnection mysqlconn)
        {
            queue.Enqueue(mysqlconn);
        }
    }
}
