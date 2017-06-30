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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ProductUI()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new SearchProduct()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new StockUI()).Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            String connString = "server = 127.0.0.1; database = pharmacy_management; username = root; password = ;";  //open the database
            MySqlConnection MySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand("select product_code, stock, re_order_size from product", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridView.DataSource = bndsrc;
                sqladp.Update(datatable);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            try
            {
                MySqlConn.Open();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (Convert.ToInt32(row.Cells[1].Value.ToString()) < Convert.ToInt32(row.Cells[2].Value.ToString()))
                    {
                        command = new MySqlCommand("update product set re_order_status = 'true' where product_code = '" + row.Cells[0].Value.ToString() + "'", MySqlConn);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command = new MySqlCommand("update product set re_order_status = '' where product_code = '" + row.Cells[0].Value.ToString() + "'", MySqlConn);
                        command.ExecuteNonQuery();
                    }
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
            command = new MySqlCommand("select product_code, name, description, category, stock, re_order_size from product where re_order_status = 'true'", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridViewReorder.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            //////////////////////////////////////////
            command = new MySqlCommand("select product_code, stock_id, exp_date from stock where status <> 'returned'", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridView.DataSource = bndsrc;
                sqladp.Update(datatable);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            try
            {
                 MySqlConn.Open();
                 foreach (DataGridViewRow row in dataGridView.Rows)
                 {

                     if (DateTime.Compare(DateTime.Parse(row.Cells[2].Value.ToString()), DateTime.Now) < 0)
                     {
                         command = new MySqlCommand("update stock set status = 'expired' where product_code = '" + row.Cells[0].Value.ToString() + "' and stock_id = '" + row.Cells[1].Value.ToString() + "'", MySqlConn);
                         command.ExecuteNonQuery();
                     }
                     else
                     {
                         command = new MySqlCommand("update stock set status = '' where product_code = '" + row.Cells[0].Value.ToString() + "' and stock_id = '" + row.Cells[1].Value.ToString() + "'", MySqlConn);
                         command.ExecuteNonQuery();
                     }
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
            command = new MySqlCommand("select product_code, stock_id, vendor, size, exp_date from stock where status = 'expired'", MySqlConn);

            try
            {
                MySqlDataAdapter sqladp = new MySqlDataAdapter();
                sqladp.SelectCommand = command;
                DataTable datatable = new DataTable();
                sqladp.Fill(datatable);
                BindingSource bndsrc = new BindingSource();
                bndsrc.DataSource = datatable;
                dataGridViewExp.DataSource = bndsrc;
                sqladp.Update(datatable);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
