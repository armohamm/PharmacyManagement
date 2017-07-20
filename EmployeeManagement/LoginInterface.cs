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
using PharmacyManagement.EmployeeManagement;


namespace PharmacyManagement
{
    public partial class LoginInterface : Form
    {

        private bool isUserNameEmpty;

        public bool IsUserNameEmpty
        {
            get { return isUserNameEmpty; }
            set { isUserNameEmpty = value; }
        }
        private bool isPasswordEmpty;

        public bool IsPasswordEmpty
        {
            get { return isPasswordEmpty; }
            set { isPasswordEmpty = value; }
        }

        public LoginInterface()
        {
            InitializeComponent();
            isUserNameEmpty = true;
            isPasswordEmpty = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isPasswordEmpty == false && isUserNameEmpty == false)
            {
                User.loginUsers(userNameTxt.Text, passwordTxt.Text);
                /*string connectionString = @"Data Source=localhost;port=3306;Initial Catalog=pharmacymanagement;User Id=root;password=''";
                MySqlConnection con = new MySqlConnection(connectionString);
                try
                {
                    con.Open();
                    String query = "Select Type,EmpID,Password from employee where EmpID = '" + userNameTxt.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //string type = reader["Type"].ToString();
                        string type = reader.GetString(0);
                        string password = reader.GetString(2);

                        if (password == passwordTxt.Text)
                        {
                            if (type == "Owner")
                            {
                                AdminInterface owner = new AdminInterface();
                                owner.Show();
                                this.Hide();
                            }
                            else if (type == "Supervisor")
                            {
                                SupervisorInterface sp = new SupervisorInterface();
                                sp.Show();
                                this.Hide();
                            }
                            else if (type == "Cashier")
                            {
                                CashierInterface emp = new CashierInterface();
                                emp.Show();
                                this.Hide();
                            }
                            else
                            {
                                nameErLbl.Visible = true;
                            }
                        }
                        else
                        {
                            nameErLbl.Visible = true;
                        }
                    }
                    if (!reader.Read())
                        nameErLbl.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }*/
            }
            else
                nameErLbl.Visible = true;

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            nameErLbl.Visible = false;
            inactiveErLbl.Visible = false;
            label1.Visible = false;
            if (userNameTxt.Text != "")
                isUserNameEmpty = false;
            else
                isUserNameEmpty = true;
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            nameErLbl.Visible = false;
            inactiveErLbl.Visible = false;
            if (passwordTxt.Text != "")
                isPasswordEmpty = false;
            else
                isPasswordEmpty = true;
            /*if (!getisPasswordEmpty() && !getisUserNameEmpty())
                loginBtn.Enabled = true;
            else
                loginBtn.Enabled = false;*/
        }

        private void userNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                loginBtn_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void userNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void displayErr()
        {
            nameErLbl.Visible = true;
        }

        public void inactiveErr()
        {
            inactiveErLbl.Visible = true;
        }

        public void clearText()
        {
            passwordTxt.Clear();
            userNameTxt.Clear();
            userNameTxt.Select();   //Same as Focus(), But Focus() is a low-level one
        }

        public void showMessage(String message)
        {
            MessageBox.Show(message);
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {
            DBConnection.loadStore();
        }

        public void showForgotPassButton()
        {
            label1.Visible = true;
        }

        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
        }

        public String getUserName()
        {
            return userNameTxt.Text;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            User.SecurityQuesObj = new SecurityQuestion();
            User.SecurityQuesObj.Show();
        }
        
    }
}
