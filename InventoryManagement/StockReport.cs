using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagement.InventoryManagement
{
    class StockReport
    {
        public void addToReport(String user, String product_code, String stock_id, String status, String vendor, String exp_date, int size, int shop, String cost_price, String unit_price)
        {
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("insert into pharmacy_management.report (user, product_code, stock_id, status, date, time, vendor, exp_date, size, shop, cost_price, unit_price) values ('" + user + "','" + product_code + "','" + stock_id + "','" + status + "','" + DateTime.Today.ToString("dd/MM/yyyy") + "','" + DateTime.Now.ToString("h:mm:ss tt") + "','" + vendor + "','" + exp_date + "','" + size + "','" + shop + "','" + cost_price + "','" + unit_price + "');", mySqlConn);
            MySqlDataReader dataReader;
            try
            {
                mySqlConn.Open();
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) { }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }
    }
}
