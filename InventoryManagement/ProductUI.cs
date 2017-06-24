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
    public partial class ProductUI : Form
    {
        public ProductUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("insert into pharmacy_management.product (product_code, name, description, category, re_order_size, unit_price) values ('" + Convert.ToInt32(label5.Text) + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + numericUpDown1.Value + "','" + textBox3.Text + "') ", MySqlConn);
            MySqlDataReader dataReader;
            try
            {
                MySqlConn.Open();
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) { }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                MySqlConn.Close();
            }
            textBox1.Text = "";
            textBox2.Text = ""; 
            comboBox1.Text = "";
            numericUpDown1.ResetText();
            textBox3.Text = "";

            MessageBox.Show("Product added successfully");
            command = new MySqlCommand("select count(*) from product", MySqlConn);

            try
            {
                MySqlConn.Open();
                label5.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
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

        private void ProductUI_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select count(*) from product", MySqlConn);
            
            try
            {
                MySqlConn.Open();
                label5.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            numericUpDown1.ResetText();
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && comboBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox8.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select * from product where product_code like '%" + textBox4.Text + "%' ;", MySqlConn);

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox8.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select * from product where name like '%" + textBox5.Text + "%' ;", MySqlConn);

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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox4.Text = "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label15.Text = row.Cells[0].Value.ToString();
                textBox6.Text = row.Cells[2].Value.ToString();
                comboBox3.Text = row.Cells[3].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();
                numericUpDown2.Value = Convert.ToInt32(row.Cells[6].Value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("update product set description = '" + textBox6.Text + "', category = '" + comboBox3.Text + "', unit_price = '" + textBox7.Text + "', re_order_size = '" + numericUpDown2.Value + "' where product_code = '" + label15.Text + "'", MySqlConn);

            try
            {
                MySqlConn.Open();
                int numRowsUpdated = command.ExecuteNonQuery();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
