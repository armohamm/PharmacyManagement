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
    public partial class StockUI : Form
    {
        public StockUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("insert into pharmacy_management.stock (product_code, stock_id, vendor, exp_date, size, cost_price, unit_price) values ('" + Convert.ToInt32(label5.Text) + "','" + Convert.ToInt32(label7.Text) + "','" + textBox3.Text + "','" + formattedDate(dateTimePicker1.Text) + "','" + numericUpDown1.Value + "','" + textBox4.Text + "','" + textBox5.Text + "') ", MySqlConn);
            MySqlDataReader dataReader;
            try
            {
                MySqlConn.Open();
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) { }

                MessageBox.Show("Stock added successfully");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                MySqlConn.Close();
            }
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            numericUpDown1.ResetText();
            textBox5.Text = "";

            

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label5.Text = row.Cells[0].Value.ToString();
                command = new MySqlCommand("select count(*) from stock where product_code = '" + label5.Text + "'", MySqlConn);

                try
                {
                    MySqlConn.Open();
                    label7.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
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
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new UpdateStock()).Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox2.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select * from product where product_code like '%" + textBox1.Text + "%' ;", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridView1.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox1.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select * from product where name like '%" + textBox2.Text + "%' ;", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridView1.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select * from product where category like '%" + textBox8.Text + "%' ;", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridView1.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label5.Text = row.Cells[0].Value.ToString();
                String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
                MySqlConnection MySqlConn = new MySqlConnection(connString);
                MySqlCommand command = new MySqlCommand("select count(*) from stock where product_code = '" + label5.Text + "'", MySqlConn);

                try
                {
                    MySqlConn.Open();
                    label7.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
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
        }
    }
}
