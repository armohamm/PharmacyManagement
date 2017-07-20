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
        private String user_name;
        private int shop;
        private String qshop;
        private String temp;
                
        public StockUI(String user_name, String qshop)
        {
            InitializeComponent();
            lblUser.Text = user_name;
            this.user_name = user_name;
            if (qshop == "Shop1")
                this.shop = 1;
            else if (qshop == "Shop2")
                this.shop = 2;
            else
                this.shop = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.ResetText();
            numericUpDown1.ResetText();
            textBox5.Text = "";
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product(label5.Text);
            if (shop == 0)
            {
                if (radioButton1.Checked)
                    shop = 1;
                if (radioButton2.Checked)
                    shop = 2;
            }
            Stock stock = new Stock(label7.Text, textBox3.Text, dateTimePicker1.Text, Convert.ToInt32(numericUpDown1.Value), shop, textBox4.Text, textBox5.Text);
            product.addStock(user_name, stock);
            
            label7.Text = "Auto-generated";
            label5.Text = "No product is selected";
            refresh();

            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            numericUpDown1.ResetText();
            textBox5.Text = "";
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
            String product_code = "";
            String stock_id = "";
            String vendor = "";
            String exp_date = "";
            String size = "";
            String cost_price = "";
            String unit_price = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                product_code = row.Cells[0].Value.ToString();
                
            }
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                stock_id = row.Cells[0].Value.ToString();
                vendor = row.Cells[1].Value.ToString();
                exp_date = row.Cells[2].Value.ToString();
                size = row.Cells[3].Value.ToString();
                cost_price = row.Cells[4].Value.ToString();
                unit_price = row.Cells[5].Value.ToString();
            }
            int shop = 0;
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select shop from stock where product_code = '" + product_code + "' and stock_id = '" + stock_id + "';", mySqlConn);
            try
            {
                mySqlConn.Open();
                MySqlDataReader datReader = command.ExecuteReader();
                while (datReader.Read())
                {
                    shop = Convert.ToInt32(datReader.GetString("shop"));
                }
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
            (new UpdateStock(user_name, product_code, stock_id, vendor, exp_date, size, cost_price, unit_price, shop)).Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            label7.Text = "No product is selected";
            button4.Enabled = false;
            button5.Enabled = false;
            textBox8.Text = "";
            textBox2.Text = "";
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, unit_price from product where product_code like '%" + textBox1.Text + "%' ;", mySqlConn);

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
            finally
            {
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            label7.Text = "No product is selected";
            button4.Enabled = false;
            button5.Enabled = false;
            textBox8.Text = "";
            textBox1.Text = "";
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, unit_price from product where name like '%" + textBox2.Text + "%' ;", mySqlConn);

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
            finally
            {
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            label7.Text = "No product is selected";
            button4.Enabled = false;
            button5.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, unit_price from product where category like '%" + textBox8.Text + "%' ;", mySqlConn);

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
            finally
            {
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                dataGridView3.Enabled = false;
            }
            else
            {
                dataGridView3.Enabled = true;
            }
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            label17.Text = "No stock selected";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label5.Text = row.Cells[0].Value.ToString();
                MySqlConnection mySqlConn = DBConnection.getConn();
                MySqlCommand command = new MySqlCommand("select count(*) from stock where product_code = '" + label5.Text + "'", mySqlConn);

                try
                {
                    mySqlConn.Open();
                    label7.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }

                if (checkBox1.Checked)
                {
                    command = new MySqlCommand("select stock_id, vendor, exp_date, size, cost_price, unit_price, status from stock where product_code = '" + label5.Text + "' and status <> 'returned' and status = 'expired' " + qshop + ";", mySqlConn);
                }
                else
                {
                    command = new MySqlCommand("select stock_id, vendor, exp_date, size, cost_price, unit_price, status from stock where product_code = '" + label5.Text + "' and status <> 'returned' " + qshop + ";", mySqlConn);
                }
                try
                {
                    MySqlDataAdapter sqladp = new MySqlDataAdapter();
                    sqladp.SelectCommand = command;
                    DataTable datatable = new DataTable();
                    sqladp.Fill(datatable);
                    BindingSource bndsrc = new BindingSource();
                    bndsrc.DataSource = datatable;
                    dataGridView3.DataSource = bndsrc;
                    sqladp.Update(datatable);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            label17.Text = "No stock selected";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label5.Text = row.Cells[0].Value.ToString();
                MySqlConnection mySqlConn = DBConnection.getConn();
                MySqlCommand command = new MySqlCommand("select count(*) from stock where product_code = '" + label5.Text + "'", mySqlConn);

                try
                {
                    mySqlConn.Open();
                    label7.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
                
                if (checkBox1.Checked)
                {
                    command = new MySqlCommand("select stock_id, vendor, exp_date, size, cost_price, unit_price, status from stock where product_code = '" + label5.Text + "' and status <> 'returned' and status = 'expired' " + qshop + ";", mySqlConn);
                }
                else
                {
                    command = new MySqlCommand("select stock_id, vendor, exp_date, size, cost_price, unit_price, status from stock where product_code = '" + label5.Text + "' and status <> 'returned' " + qshop + ";", mySqlConn);
                }
                try
                {
                    MySqlDataAdapter sqladp = new MySqlDataAdapter();
                    sqladp.SelectCommand = command;
                    DataTable datatable = new DataTable();
                    sqladp.Fill(datatable);
                    BindingSource bndsrc = new BindingSource();
                    bndsrc.DataSource = datatable;
                    dataGridView3.DataSource = bndsrc;
                    sqladp.Update(datatable);
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String product_code = "";
            String stock_id = "";
            String size = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                product_code = row.Cells[0].Value.ToString();

            }
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                stock_id = row.Cells[0].Value.ToString();
                size = row.Cells[3].Value.ToString();
            }

            int shop = 0;
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select shop from stock where product_code = '" + product_code + "' and stock_id = '" + stock_id + "';", mySqlConn);
            try
            {
                mySqlConn.Open();
                MySqlDataReader datReader = command.ExecuteReader();
                while (datReader.Read())
                {
                    shop = Convert.ToInt32(datReader.GetString("shop"));
                }
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
            (new ReturnStock(user_name, product_code, stock_id, size, shop)).Show();
            refresh();
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                label17.Text = row.Cells[0].Value.ToString();
                button4.Enabled = true;
                button5.Enabled = true;
            }
        }

        private void StockUI_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            numericUpDown1.ResetText();
            if (shop != 0)
            {
                grpBoxShop.Visible = false;
                productToolStripMenuItem.Enabled = false;
            }
            dateTimePicker1.MinDate = DateTime.Today.AddDays(1);
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, unit_price from product where product_code like '%" + textBox1.Text + "%' ;", mySqlConn);

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
            finally
            {
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }

            if (this.shop == 0)
                qshop = "";
            else
                qshop = "and shop = '" + shop.ToString() + "' ;";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (label5.Text != "No product is selected" && textBox3.Text.Length != 0 && isDigitsOnly(textBox4.Text) && isDigitsOnly(textBox5.Text) && numericUpDown1.Value > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private bool isDigitsOnly(String str)
        {
            if (str.Length == 0)
                return false;
            int count = 0;
            foreach (char c in str)
            {
                if ((c < '0' || c > '9') && c != '.')
                    return false;
                if (c == '.')
                {
                    count = count + 1;
                    if (count > 1)
                        return false;
                }
            }
            try
            {
                String temp = str.Split('.')[1];
                if (temp.Length > 2)
                    return false;
            }
            catch(Exception es) {}
            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Documents\Visual Studio 2012\Projects\PharmacyManagement\PharmacyManagement\Resources\Help.pdf");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh()
        {
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command;
            if (textBox2.Text.Length != 0)
                command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, unit_price from product where name like '%" + textBox2.Text + "%' ;", mySqlConn);
            else if (textBox1.Text.Length != 0)
                command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, unit_price from product where product_code like '%" + textBox1.Text + "%' ;", mySqlConn);
            else
                command = new MySqlCommand("select product_code, name, description, category, stock_shop_1, stock_shop_2, unit_price from product where category like '%" + textBox8.Text + "%' ;", mySqlConn);

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
            finally
            {
                mySqlConn.Close();
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            refresh();
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ProductUI(user_name)).Show();
        }

        private void sotcksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new StockUI(user_name, temp)).Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new SearchProduct(user_name)).Show();
        }
    }
}
