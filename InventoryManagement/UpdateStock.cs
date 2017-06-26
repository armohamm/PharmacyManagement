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

namespace PharmacyManagement.InventoryManagement
{
    public partial class UpdateStock : Form
    {
        String product_code;
        String stock_id;
        String vendor;
        String exp_date;
        String size;
        String cost_price;
        String unit_price;

        public UpdateStock(String product_code, String stock_id, String vendor, String exp_date, String size, String cost_price, String unit_price)
        {
            InitializeComponent();
            this.product_code = product_code;
            this.stock_id = stock_id;
            this.vendor = vendor;
            this.exp_date = exp_date;
            this.size = size;
            this.cost_price = cost_price;
            this.unit_price = unit_price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stock_size = 0;
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select stock from product where product_code = '" + product_code + "'", MySqlConn);
            try
            {
                MySqlConn.Open();
                MySqlDataReader datReader = command.ExecuteReader();
                while (datReader.Read())
                {
                    stock_size = Convert.ToInt32(datReader.GetString("stock"));
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                MySqlConn.Close();
            }
            command = new MySqlCommand("update stock set vendor = '" + textBox3.Text + "', exp_date = '" + formattedDate(dateTimePicker1.Text) + "', size = '" + numericUpDown1.Value.ToString() + "', unit_price = '" + textBox4.Text + "', cost_price = '" + textBox5.Text + "' where product_code = '" + product_code + "' and stock_id = '" + stock_id + "'", MySqlConn);
            MySqlCommand command2 = new MySqlCommand("update product set stock = '" + (stock_size + numericUpDown1.Value - Convert.ToInt32(size)) + "' where product_code = '" + product_code + "'", MySqlConn);
            try
            {
                MySqlConn.Open();
                int numRowsUpdated = command.ExecuteNonQuery();
                int numRowsUpdated2 = command2.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                MySqlConn.Close();
            }
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            label3.Text = product_code;
            label4.Text = stock_id;
            textBox3.Text = vendor;
            dateTimePicker1.Value = DateTime.Parse(exp_date);
            numericUpDown1.Value = Convert.ToInt32(size);
            textBox4.Text = unit_price;
            textBox5.Text = cost_price;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String formattedDate(String date)
        {
            String[] arr = date.Split('/');
            String temp = arr[2];
            arr[2] = arr[1];
            arr[1] = arr[0];
            arr[0] = temp;
            return String.Join("-", arr);
        }
    }
}
