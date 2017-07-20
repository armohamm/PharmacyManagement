using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagement
{
    class Return
    {
        private string invoice_number;
        private string returnDetails;

        public Return(string invoice_number, string returnDetails) 
        {
            this.invoice_number = invoice_number;
            this.returnDetails = returnDetails;
        }

        public void execute(string username, int shop, DataGridView dataGridView3) 
        {
            DateTime currentDateandTime = DateTime.Now;
            string date = "";
            string time = "";
            date = currentDateandTime.ToShortDateString();
            time = currentDateandTime.ToShortTimeString();

            MySqlConnection connection = DBConnection.getConn();
            connection.Open();

            string insertQuery = "INSERT INTO pharmacy_management.return_table VALUES (@invoice_number,@user,@shop,@details,@date,@time)";
            MySqlCommand command =new MySqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@invoice_number", invoice_number);
            command.Parameters.AddWithValue("@user", username);
            command.Parameters.AddWithValue("@shop", shop);
            command.Parameters.AddWithValue("@details", returnDetails);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@time", time);
            command.ExecuteNonQuery();
            connection.Close();

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                string quantity = row.Cells[3].Value.ToString();
                
                string currentstock = "";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT stock_shop_" + shop + " FROM pharmacy_management.product WHERE product_code = '" + Convert.ToString(row.Cells[1].Value) + "'";
                
                try
                {
                    connection.Open();
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        currentstock = Convert.ToInt32(myReader.GetString("stock_shop_" + shop)).ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                string newstock = Convert.ToString(Convert.ToInt32(currentstock) + Convert.ToInt32(quantity));

                string updatequery = "UPDATE pharmacy_management.product SET stock_shop_" + shop + " = '" + newstock + "' WHERE product_code = '" + Convert.ToString(row.Cells[1].Value) + "' ";
                MySqlCommand cmdsampleinventory = new MySqlCommand(updatequery, connection);
                try
                {
                    connection.Open();
                    int myread2er = cmdsampleinventory.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            DBConnection.returnConn(connection);
            connection = null;
        }
    }
}
