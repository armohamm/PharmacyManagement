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
using System.Collections;

namespace PharmacyManagement
{
    class Sale
    {
        public ArrayList sales;

        public Sale()
        {
            sales = new ArrayList();
        }

        public void add(Item item)
        {
            sales.Add(item);
        }

        

        public void execute(DataGridView datagridview, DataGridView datagridview2, string amount, string user_name, int shop)
        {   

            MySqlConnection connection = DBConnection.getConn();
 
            for (int i = 0; i < datagridview.Rows.Count; i++)
            {
                string currentstock = "";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT stock_shop_" + shop + " FROM pharmacy_management.product WHERE product_code = '" + Convert.ToString(datagridview.Rows[i].Cells[1].Value) + "'";

                try
                {
                    connection.Open();
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        currentstock = Convert.ToString(Convert.ToInt32(myReader.GetString("stock_shop_" + shop)));
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
                /*string stock_requested = Convert.ToString(datagridview.Rows[i].Cells[3].Value);
                MessageBox.Show(stock_requested);
                MessageBox.Show(currentstock);
                int value = Convert.ToInt32(currentstock) - Convert.ToInt32(stock_requested);
                MessageBox.Show(Convert.ToString(value));*/


                string newstock = Convert.ToString(Convert.ToInt32(currentstock) - Convert.ToInt32(datagridview.Rows[i].Cells[3].Value));
                string updatequery = "UPDATE pharmacy_management.product SET stock_shop_" + shop + " = '" + newstock + "' WHERE product_code = '" + Convert.ToString(datagridview.Rows[i].Cells[1].Value) + "' ";
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
            string details = "";
            for (int i = 0; i < datagridview.Rows.Count; i++)
            {
                string product_code = "";
                string product = "";
                string quantity = "";
                string price = "";
                string total = "";

                product_code = Convert.ToString(datagridview.Rows[i].Cells[1].Value);
                product = Convert.ToString(datagridview.Rows[i].Cells[2].Value);
                quantity = Convert.ToString(datagridview.Rows[i].Cells[3].Value);
                price = Convert.ToString(datagridview.Rows[i].Cells[4].Value);
                total = Convert.ToString(datagridview.Rows[i].Cells[5].Value);
                string newname = "";
                try
                {
                    string[] names = product.Split();
                    foreach(string item in names)
                    {
                        newname += item + "_";
                    }
                    
                    
                }
                catch { }
                string outcome = newname.Substring(0, newname.Length - 1);

                details += product_code + " " + outcome + " " + quantity + " " + price + " " + total + "/";
            }
            try
            {
                DateTime current = DateTime.Now;
                string date = "";
                string time = "";

                date = current.ToShortDateString();
                time = current.ToShortTimeString();
                connection.Open();
                string insertquery = "INSERT INTO pharmacy_management.invoice VALUES (null,@user,@shop,@details,@date,@time)";
                MySqlCommand command = new MySqlCommand(insertquery, connection);
                command.Parameters.AddWithValue("@user", user_name);
                command.Parameters.AddWithValue("@shop", shop);
                command.Parameters.AddWithValue("@details", details);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Invoice frm = new Invoice(user_name);
            for (int i = 0; i < datagridview.RowCount; i++)
            {
                frm.dataGridView3.Rows.Add();
                for (int j = 2; j < 6; j++)
                {
                    frm.dataGridView3.Rows[i].Cells[j - 2].Value = datagridview.Rows[i].Cells[j].Value;
                    //MessageBox.Show(Convert.ToString(this.datagridview.Rows[i].Cells[j].Value));
                }

            }

            MySqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "SELECT * FROM pharmacy_management.invoice WHERE invoice_number = (SELECT MAX(invoice_number) FROM pharmacy_management.invoice)";
            string invoice_num = "";
            try
            {
                connection.Open();
                MySqlDataReader myReader2 = cmd2.ExecuteReader();
                while (myReader2.Read())
                {
                    invoice_num = Convert.ToString(Convert.ToInt32(myReader2.GetString("Invoice_number")));
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
            frm.invcnumtxtx.Text = invoice_num;
            frm.ttlbilltxt.Text = amount;

            string selectQuery = "SELECT product_code, name, description, category, stock_shop_" + shop + ",unit_price, re_order_size  FROM pharmacy_management.product ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            datagridview2.DataSource = dt;
            datagridview.Rows.Clear();
            frm.Show();
            DBConnection.returnConn(connection);
            connection = null;
        }
    }
}
