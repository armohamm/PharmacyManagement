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
        public ProductUI(String user_name)
        {
            InitializeComponent();
            lblUser.Text = user_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product(label5.Text);
            product.addProduct(txtBoxName.Text, txtBoxDesc.Text, cmbBoxCategory.Text, Convert.ToInt32(numUpDownRSize.Value), txtBoxUPrice.Text); 
            
            txtBoxName.Text = "";
            txtBoxDesc.Text = ""; 
            cmbBoxCategory.Text = "";
            numUpDownRSize.ResetText();
            txtBoxUPrice.Text = "";

            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select count(*) from product", mySqlConn);

            try
            {
                mySqlConn.Open();
                label5.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
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

        private void ProductUI_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select * from product where product_code like '%" + txtBoxPCodeS.Text + "%' ;", mySqlConn);

            try
            {
                mySqlConn.Open();
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
            }

            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            command = new MySqlCommand("select count(*) from product", mySqlConn);
            
            try
            {
                mySqlConn.Open();
                label5.Text = (Convert.ToInt32(command.ExecuteScalar()) + 1).ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            txtBoxDesc.Text = "";
            cmbBoxCategory.Text = "";
            numUpDownRSize.ResetText();
            txtBoxUPrice.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxName.Text.Length != 0 && txtBoxDesc.Text.Length != 0 && isDigitsOnly(txtBoxUPrice.Text) && isDigitsOnly(cmbBoxCategory.Text))
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label15.Text = "No product is selected";
            txtBoxPNameS.Text = "";
            txtBoxCategoryS.Text = "";
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select * from product where product_code like '%" + txtBoxPCodeS.Text + "%' ;", mySqlConn);

            try
            {
                mySqlConn.Open();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label15.Text = "No product is selected";
            txtBoxPCodeS.Text = "";
            txtBoxCategoryS.Text = "";
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select * from product where name like '%" + txtBoxPNameS.Text + "%' ;", mySqlConn);

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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label15.Text = "No product is selected";
            txtBoxPNameS.Text = "";
            txtBoxPCodeS.Text = "";
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select * from product where category like '%" + txtBoxCategoryS.Text + "%' ;", mySqlConn);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                label15.Text = row.Cells[0].Value.ToString();
                txtBoxDescU.Text = row.Cells[2].Value.ToString();
                cmbBoxCategoryU.Text = row.Cells[3].Value.ToString();
                txtBoxUPriceU.Text = row.Cells[6].Value.ToString();
                numUpDownROrderU.Value = Convert.ToInt32(row.Cells[7].Value);
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product product = new Product(label15.Text);
            product.updateProduct(txtBoxDescU.Text, cmbBoxCategoryU.Text, Convert.ToInt32(numUpDownROrderU.Value), txtBoxUPriceU.Text);

            label15.Text = "No product is selected";
            txtBoxDescU.Text = "";
            cmbBoxCategoryU.SelectedIndex = 0;
            txtBoxUPriceU.Text = "";
            numUpDownROrderU.ResetText();
            refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (label15.Text != "No product is selected" && txtBoxDescU.Text.Length != 0 && isDigitsOnly(txtBoxUPriceU.Text) && isDigitsOnly(cmbBoxCategoryU.Text))
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

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
                    if (++count > 1)
                        return false;
                }
            }
            try
            {
                String temp = str.Split('.')[1];
                if (temp.Length > 2)
                    return false;
            }
            catch (Exception es) { }
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

        private void refresh()
        {
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command;
            if (txtBoxPNameS.Text.Length != 0)
                command = new MySqlCommand("select * from product where name like '%" + txtBoxPNameS.Text + "%' ;", mySqlConn);
            else if (txtBoxPCodeS.Text.Length != 0)
                command = new MySqlCommand("select * from product where product_code like '%" + txtBoxPCodeS.Text + "%' ;", mySqlConn);
            else
                command = new MySqlCommand("select * from product where category like '%" + txtBoxCategoryS.Text + "%' ;", mySqlConn);

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
    }
}
