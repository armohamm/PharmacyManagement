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

namespace PharmacyManagement
{
    public partial class ShowEmployeeInfomationInterface : Form
    {
        private String empID;
        string connectionString = @"Data Source=localhost;port=3306;Initial Catalog=pharmacy_management;User Id=root;password=''";
        public ShowEmployeeInfomationInterface()
        {
            InitializeComponent();
            contactNoTxt.MaxLength = 10;
            
        }

        private void ShowEmployeeInfomation_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DBConnection.getConn();
            try
            {
                if (nameTxt.Text != "")
                {
                    nicTxt.Enabled = false;
                    employeeIdTxt.Enabled = false;
                    /*con.Open();
                    String query = "Select FirstName,LastName,EmpID,NIC,Address,Shop,Type,ContactNo from employee where FirstName like '%" + nameTxt.Text + "%'";
                    DataTable table = new DataTable();
                    MySqlDataAdapter ada;
                    //MySqlCommand cmd;
                    for (int i = 0; i < 2; i++)
                    {
                        //cmd = new MySqlCommand(query, con);
                        ada = new MySqlDataAdapter(query, con);
                        //ada.SelectCommand = cmd;
                        ada.Fill(table);
                        //ada.Update(table);
                        query = "Select FirstName,LastName,EmpID,NIC,Address,Shop,Type,ContactNo from employee where LastName like '%" + nameTxt.Text + "%'";
                    }
                    //BindingSource bsource = new BindingSource();
                    //bsource.DataSource = table;
                    dataGridView1.DataSource = table;*/
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "FirstName LIKE '"+nameTxt.Text+"%'";
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "LastName LIKE '" + nameTxt.Text + "%'";
                    //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format();
                    /*foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().StartsWith(nameTxt.Text) || row.Cells[1].Value.ToString().StartsWith(nameTxt.Text))
                        {
                           
                        }
                    }*/
                }
                else
                {
                    showDataGridView();
                    nicTxt.Enabled = true;
                    employeeIdTxt.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
        }

        private void nicTxt_TextChanged(object sender, EventArgs e)
        {

            MySqlConnection con = DBConnection.getConn();
            try
            {
                if (nicTxt.Text != "")
                {
                    nameTxt.Enabled = false;
                    employeeIdTxt.Enabled = false;
                    /*con.Open();
                    String query = "Select FirstName,LastName,EmpID,NIC,Address,Shop,Type,ContactNo from employee where NIC like '%" + nicTxt.Text + "%'";
                    //MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter ada = new MySqlDataAdapter(query, con);
                    //ada.SelectCommand = cmd;
                    DataTable table = new DataTable();
                    ada.Fill(table);
                    //BindingSource bsource = new BindingSource();
                    //bsource.DataSource = table;
                    dataGridView1.DataSource = table;
                    //ada.Update(table);*/
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "NIC LIKE '" + nicTxt.Text + "%'";
                }
                else
                {
                    showDataGridView();
                    nameTxt.Enabled = true;
                    employeeIdTxt.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
        }

        private void employeeIdTxt_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = DBConnection.getConn();
            try
            {
                if (employeeIdTxt.Text != "")
                {
                    nameTxt.Enabled = false;
                    nicTxt.Enabled = false;
                    /*con.Open();
                    String query = "Select FirstName,LastName,EmpID,NIC,Address,Shop,Type,ContactNo from employee where EmpID like '%" + employeeIdTxt.Text + "%'";
                    //MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter ada = new MySqlDataAdapter(query, con);
                    //ada.SelectCommand = cmd;
                    DataTable table = new DataTable();
                    ada.Fill(table);
                    //BindingSource bsource = new BindingSource();
                    //bsource.DataSource = table;
                    dataGridView1.DataSource = table;
                    //ada.Update(table);*/
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "EmpID LIKE '" + employeeIdTxt.Text + "%'";
                }
                else
                {
                    showDataGridView();
                    nameTxt.Enabled = true;
                    nicTxt.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                groupBox1.Show();
                addressTxt.Focus();
                addressTxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                contactNoTxt.Text = dataGridView1.SelectedRows[0].Cells[8].Value + string.Empty;
                shopCBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                typeCBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value + string.Empty;
                if (typeCBox.Text == "Owner")
                {
                    typeCBox.Enabled = false;
                    shopCBox.Enabled = false;
                }
                else
                {
                    typeCBox.Enabled = true;
                    shopCBox.Enabled = true;
                }
                statusCbx.Text = dataGridView1.SelectedRows[0].Cells[7].Value + string.Empty;
                EMPIDLbl.Text = "Employee ID : "+ dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                setEmpID(dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty);
            }
            else
            {
                MessageBox.Show("Select only one row to update");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = DBConnection.getConn();
            try
            {
                string query = "update employee set Address ='" + addressTxt.Text + "',ContactNo='" + contactNoTxt.Text + "',Shop='" + shopCBox.Text + "',Type='" + typeCBox.Text + "',Status='"+statusCbx.Text+"' where EmpID = '" + getEmpID() + "'";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success!");
                groupBox1.Visible = false;
                showDataGridView();
                selectRaw(getEmpID());    //Select updated row just after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }
            
        }

        private void setEmpID(String empID)
        {
            this.empID = empID;
        }
        private String getEmpID()
        {
            return empID;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDataGridView()
        {
            MySqlConnection con = DBConnection.getConn();
            try
            {
                con.Open();
                string query = "Select FullName,FirstName,EmpID,NIC,Address,Shop,Type,Status,ContactNo from employee";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
                dataGridView1.Rows[0].Selected = false;
                //dataGridView1.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                DBConnection.returnConn(con);
                con = null;
            }

        }

        private bool getIsSaveBtnEnable()
        {
            if (addressTxt.Text.Length >=5)
                return true;
            else
                return false;
        }

        private void shopCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (getIsSaveBtnEnable())
                saveBtn.Enabled = true;
            else
                saveBtn.Enabled = false;
        }

        private void typeCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (getIsSaveBtnEnable())
                saveBtn.Enabled = true;
            else
                saveBtn.Enabled = false;
            if (typeCBox.Text == "Owner")
            {
                if(!shopCBox.Items.Contains("Shop"))
                    shopCBox.Items.Add("Shop");
                shopCBox.Enabled = false;
                shopCBox.Text = "Shop";
            }
            else
            {
                shopCBox.Enabled = true;
                if (shopCBox.Items.Contains("Shop"))
                    shopCBox.Items.Remove("Shop");
            }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (getIsSaveBtnEnable())
                saveBtn.Enabled = true;
            else
                saveBtn.Enabled = false;
        }

        private void selectRaw(String empID)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[2].Value.ToString().Equals(empID))
                {
                    row.Selected = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.Focus();
                    break;
                }
            }
        }

        private void nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            gotoDataGridView(e);
        }

        private void gotoDataGridView(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.Focus();
                dataGridView1.Rows[0].Selected = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void nicTxt_KeyDown(object sender, KeyEventArgs e)
        {
            gotoDataGridView(e);
        }

        private void employeeIdTxt_KeyDown(object sender, KeyEventArgs e)
        {
            gotoDataGridView(e);
        }

        private void dataGridView1_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1_KeyDown(this, new KeyEventArgs(Keys.Enter));
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateBtn_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void contactNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allowing only numbers and 'Backspace'
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void addressTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contactNoTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void shopCBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveBtn.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void contactNoTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (typeCBox.Enabled)
                {
                    typeCBox.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    statusCbx.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }

            }
        }

        private void typeCBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                statusCbx.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void statusCbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (shopCBox.Enabled)
                {
                    shopCBox.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    saveBtn.Focus();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                typeCBox.Enabled = true;
            }
            else
                typeCBox.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Desktop\PharmacyManagement\PharmacyManagement\Resources\ShoEmployeeInformation.pdf");
        }
    }
}
