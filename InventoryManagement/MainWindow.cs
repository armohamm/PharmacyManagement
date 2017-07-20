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
        private String user_name;
        private String type;
        private String shop;
        private FormCollection list;
        private List<Form> opened;

        public MainWindow(String user_name, String type, String shop)
        {
            InitializeComponent();
            lblUser.Text = user_name;
            this.user_name = user_name;
            this.type = type;
            this.shop = shop;
            this.list = Application.OpenForms;
            this.opened = new List<Form>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.InventoryManagement.ProductUI")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                ProductUI pUI = new ProductUI(user_name);
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.InventoryManagement.SearchProduct")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                SearchProduct sP = new SearchProduct(user_name);
                opened.Add(sP);
                sP.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.InventoryManagement.StockUI")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                StockUI sUI = new StockUI(user_name, shop);
                opened.Add(sUI);
                sUI.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (type == "Supervisor")
            {
                button1.Enabled = false;
                productsToolStripMenuItem1.Enabled = false;
            }
            MySqlConnection MySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, stock_shop_1, stock_shop_2, re_order_size from product", MySqlConn);

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
                    if (Convert.ToInt32(row.Cells[1].Value.ToString()) < Convert.ToInt32(row.Cells[3].Value.ToString()) || Convert.ToInt32(row.Cells[2].Value.ToString()) < Convert.ToInt32(row.Cells[3].Value.ToString()))
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
            command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, re_order_size from product where re_order_status = 'true'", MySqlConn);

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
            finally
            {
                DBConnection.returnConn(MySqlConn);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.InventoryManagement.ProductUI")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                ProductUI pUI = new ProductUI(user_name);
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void stocksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.InventoryManagement.StockUI")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                StockUI sUI = new StockUI(user_name, shop);
                opened.Add(sUI);
                sUI.Show();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.InventoryManagement.SearchProduct")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                SearchProduct sP = new SearchProduct(user_name);
                opened.Add(sP);
                sP.Show();
            }
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e){}

        private void aboutTeamsolutionToolStripMenuItem_Click(object sender, EventArgs e){}

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in opened)
            {
                if (!form.Equals(this))
                    form.Close();
            }
        }
    }
}
