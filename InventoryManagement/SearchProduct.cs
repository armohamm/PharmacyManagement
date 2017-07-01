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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void txtBoxPCode_TextChanged(object sender, EventArgs e)
        {
            txtBoxPName.Text = "";
            textBox1.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock, unit_price from product where product_code like '%" + txtBoxPCode.Text + "%' ;", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridViewProduct.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBoxPName_TextChanged(object sender, EventArgs e)
        {
            txtBoxPCode.Text = "";
            textBox1.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock, unit_price from product where name like '%" + txtBoxPName.Text + "%' ;", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridViewProduct.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtBoxPCode.Text = "";
            txtBoxPName.Text = "";
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock, unit_price from product where category like '%" + textBox1.Text + "%' ;", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridViewProduct.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void dataGridViewStock_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProduct.SelectedRows)
            {
                String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ; Convert Zero Datetime = True;";  //open the database
                MySqlConnection MySqlConn = new MySqlConnection(connString);
                MySqlCommand command = new MySqlCommand("select stock_id, vendor, exp_date, size, entered_date, cost_price, unit_price, status from stock where product_code = '" + row.Cells[0].Value.ToString() + "' and status <> 'returned' ;", MySqlConn);

                try
                {
                    MySqlDataAdapter sqladp = new MySqlDataAdapter();
                    sqladp.SelectCommand = command;
                    DataTable datatable = new DataTable();
                    sqladp.Fill(datatable);
                    BindingSource bndsrc = new BindingSource();
                    bndsrc.DataSource = datatable;
                    dataGridViewStock.DataSource = bndsrc;
                    sqladp.Update(datatable);
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
