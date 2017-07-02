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
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock, unit_price from product where product_code like '%" + txtBoxPCode.Text + "%' ;", mySqlConn);

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
            finally
            {
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void txtBoxPName_TextChanged(object sender, EventArgs e)
        {
            txtBoxPCode.Text = "";
            textBox1.Text = "";
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock, unit_price from product where name like '%" + txtBoxPName.Text + "%' ;", mySqlConn);

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
            finally
            {
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
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
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock, unit_price from product where category like '%" + textBox1.Text + "%' ;", mySqlConn);

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
            finally
            {
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        private void dataGridViewStock_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProduct.SelectedRows)
            {
                MySqlConnection mySqlConn = DBConnection.getConn();
                MySqlCommand command = new MySqlCommand("select stock_id, vendor, exp_date, size, entered_date, cost_price, unit_price, status from stock where product_code = '" + row.Cells[0].Value.ToString() + "' and status <> 'returned' ;", mySqlConn);

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
                finally
                {
                    DBConnection.returnConn(mySqlConn);
                    mySqlConn = null;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Documents\Visual Studio 2012\Projects\PharmacyManagement\PharmacyManagement\Resources\Help.pdf");
        }
    }
}
