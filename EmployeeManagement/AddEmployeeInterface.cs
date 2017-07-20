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
    public partial class AddEmployeeInterface : Form
    {
        List<Label> errorLblList;
        List<TextBox> textBoxList;

        public AddEmployeeInterface()
        {
            InitializeComponent();
            contactNoTxt.MaxLength = 10;
            shopCbx.Text = "Select Shop";   //Initial value of comboBox
            typeCbx.Text = "Select Type";   //Initial value of comboBox
            statusCbx.Text = "Select Status";
            textBoxList = new List<TextBox> { fullNameTxt, firstNameTxt, nicTxt, employeeIdTxt, addressTxt, passwordTxt, contactNoTxt };
            errorLblList = new List<Label> { fullNameErLbl, firstNameErLbl, niceErLbl, empIDErLbl, addressErLbl, passErLbl };
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!isTextBoxEmpty())
            {
                /*string conString = @"Data Source=localhost;port=3306;Initial Catalog=pharmacymanagement;User Id=root;password=''";
                string query = "insert into employee (EmpID,FirstName,LastName,NIC,Address,ContactNo,Shop,Type,Password) values ('" + employeeIdTxt.Text + "','" + firstNameTxt.Text + "','" + lastNameTxt.Text + "','" + nicTxt.Text + "','" + addressTxt.Text + "','" + contactNoTxt.Text + "','" + shopCbx.Text + "','" + typeCbx.Text + "','" + passwordTxt.Text + "');";
                MySqlConnection con = new MySqlConnection(conString);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    clearAll();
                    MessageBox.Show("Successfully added the new Employee!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }*/
                if (contactNoTxt.Text == "")
                    contactNoTxt.Text = "0";
                if (typeCbx.Text == "Owner")
                {
                    User owner = new Owner(employeeIdTxt.Text, fullNameTxt.Text, firstNameTxt.Text, nicTxt.Text, addressTxt.Text, Int32.Parse(contactNoTxt.Text), shopCbx.Text, typeCbx.Text, statusCbx.Text, passwordTxt.Text);
                }
                else if (typeCbx.Text == "Supervisor")
                {
                    User supervisor = new Supervisor(employeeIdTxt.Text, fullNameTxt.Text, firstNameTxt.Text, nicTxt.Text, addressTxt.Text, Int32.Parse(contactNoTxt.Text), shopCbx.Text, typeCbx.Text, statusCbx.Text, passwordTxt.Text);
                }
                else
                {
                    User cashier = new Cashier(employeeIdTxt.Text, fullNameTxt.Text, firstNameTxt.Text, nicTxt.Text, addressTxt.Text, Int32.Parse(contactNoTxt.Text), shopCbx.Text, typeCbx.Text, statusCbx.Text, passwordTxt.Text);
                }
            }
            else
                MessageBox.Show("Fail in adding the new Employee!");
                
            
            

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            clearAllText();
            errorLblDisappear();
        }

        public void clearAllText()
        {
            //clear all the entered data from textBoxes and set initial values for comboBoxes
            for (int i = 0; i < textBoxList.Count ; i++)
            {
                textBoxList[i].Clear();
            }
            shopCbx.Text = "Select Shop";
            typeCbx.Text = "Select Type";
            statusCbx.Text = "Select Status";
            
        }

        private void setStringTextBox(KeyPressEventArgs e)  
        {
            //Set textBox for only allowing 'a' to 'z' ('A' to 'Z') letters, 'Space', and 'Backspace'
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == 8 || e.KeyChar == 32)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void firstNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Set only for alphabatic letters
            setStringTextBox(e);
        }

        private void lastNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Set only for alphabatic letters
            setStringTextBox(e);
        }

        private void nicTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allowing only integers, 'v', 'V', and 'N' (For Passport number) 
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 'v' || e.KeyChar == 'V' || e.KeyChar == 8 || e.KeyChar == 'N')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void employeeIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allowing only numbers and letters
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
                e.Handled = false;
            else
                e.Handled = true; 

        }

        private void contactNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allowing only numbers and 'Backspace'
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private bool isTextBoxEmpty()
        {
            bool empty = false;
            for (int i = 0; i < textBoxList.Count - 1; i++)
            {
                // Check for empty text boxes and call for showing error labels for each of them
                if (textBoxList[i].Text == "")
                {
                    empty = empty || true;
                    errorDisplay(errorLblList[i]);
                }
                
                else
                    empty = empty || false;
            }
            if (shopCbx.Text == "Select Shop")
            {
                empty = empty || true;
                errorDisplay(shopErLbl);
            }
            else
                empty = empty || false;
            if (typeCbx.Text == "Select Type")
            {
                empty = empty || true;
                errorDisplay(typeErLbl);
            }
            else
                empty = empty || false;
            if (statusCbx.Text == "Select Status")
            {
                empty = empty || true;
                errorDisplay(statusErLbl);
            }
            else
                empty = empty || false;

            return empty;
        }

        private void errorDisplay(Label label)
        {
            //Display error label 
            label.Visible = true;
        }

        private void errorLblDisappear()
        {
            //ALl error labels disappear when needed
            for (int i = 0; i < errorLblList.Count; i++)
            {
                errorLblList[i].Visible = false;
            }
            shopErLbl.Visible = false;
            typeErLbl.Visible = false;
            statusErLbl.Visible = false;
        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {
            // Disappear error label when text changes
            fullNameErLbl.Visible = false;
        }

        private void lastNameTxt_TextChanged(object sender, EventArgs e)
        {
            // Disappear error label when text changes
            firstNameErLbl.Visible = false;
        }

        private void nicTxt_TextChanged(object sender, EventArgs e)
        {
            // Disappear error label when text changes
            niceErLbl.Visible = false;
        }

        private void employeeIdTxt_TextChanged(object sender, EventArgs e)
        {
            // Disappear error label when text changes
            empIDErLbl.Visible = false;
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            // Disappear error label when text changes
            addressErLbl.Visible = false;
        }

        private void shopCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disappear error label selecting an item
            shopErLbl.Visible = false;
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            // Disappear error label when text changes
            passErLbl.Visible = false;
        }

        private void typeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disappear error label selecting an item
            typeErLbl.Visible = false;
            if (typeCbx.Text.Equals("Owner"))
            {
                shopCbx.Enabled = false;
                if (!shopCbx.Items.Contains("Shop"))
                    shopCbx.Items.Add("Shop");
                shopCbx.Text = "Shop";
            }
            else if (typeCbx.Text.Equals("Select Type"))
            {
                shopCbx.Enabled = false;
                shopCbx.Text = "Select Shop";
            }
            else
            {
                shopCbx.Enabled = true;
                shopCbx.Text = "Select Shop";
                if (shopCbx.Items.Contains("Shop"))
                    shopCbx.Items.Remove("Shop");
            }
        }

        private void shopCbx_DropDown(object sender, EventArgs e)
        {
            //Remove initial text from the collection when Drop downs the list
            if (shopCbx.Items.Contains("Select Shop"))
                shopCbx.Items.Remove("Select Shop");
        }

        private void shopCbx_DropDownClosed(object sender, EventArgs e)
        {
            //Again add the initial text to the colletion and set it as text if not any item is selected
            if(!shopCbx.Items.Contains("Select Shop"))
                shopCbx.Items.Add("Select Shop");
            if(! (shopCbx.SelectedIndex > -1))
                shopCbx.Text = "Select Shop";
        }

        private void typeCbx_DropDown(object sender, EventArgs e)
        {
            //Remove initial text from the collection when Drop downs the list
            if(typeCbx.Items.Contains("Select Type"))
                typeCbx.Items.Remove("Select Type");
        }

        private void typeCbx_DropDownClosed(object sender, EventArgs e)
        {
            //Again add the initial text to the colletion and set it as text if not any item is selected
            if (!typeCbx.Items.Contains("Select Type"))
                typeCbx.Items.Add("Select Type");
            if (!(typeCbx.SelectedIndex > -1))
                typeCbx.Text = "Select Type";
            
        }

        private void statusCbx_DropDown(object sender, EventArgs e)
        {
            //Remove initial text from the collection when Drop downs the list
            if (statusCbx.Items.Contains("Select Status"))
                statusCbx.Items.Remove("Select Status");
        }

        private void statusCbx_DropDownClosed(object sender, EventArgs e)
        {
            //Again add the initial text to the colletion and set it as text if not any item is selected
            if (!statusCbx.Items.Contains("Select Status"))
                statusCbx.Items.Add("Select Status");
            if (!(statusCbx.SelectedIndex > -1))
                statusCbx.Text = "Select Status";
        }

        public void showMessage(String message)
        {
            MessageBox.Show(message);
        }

        private void statusCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusErLbl.Visible = false;
        }

        private void AddEmployeeInterface_Load(object sender, EventArgs e)
        {
            shopCbx.Enabled = false;
        }

        private void contactNoTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Desktop\PharmacyManagement\PharmacyManagement\Resources\Add-Employee.pdf");
        
        }

    }
}
