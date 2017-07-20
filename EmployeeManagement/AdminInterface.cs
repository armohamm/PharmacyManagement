using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class AdminInterface : Form
    {
        private FormCollection list;
        private List<Form> opened;

        public AdminInterface()
        {
            InitializeComponent();
            list = Application.OpenForms;
            opened = new List<Form>();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddEmployeeInterface>().Any())
            {
                User.AddEmpObj.Select();
            }
            else
            {
                User.AddEmpObj = new AddEmployeeInterface();
                opened.Add(User.AddEmpObj);
                User.AddEmpObj.Show();
            }
        }

        private void showEmployeeBtn_Click(object sender, EventArgs e)
        {
            /*ShowEmployeeInfomationInterface showEmp = new ShowEmployeeInfomationInterface();
            showEmp.Show();*/
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.ShowEmployeeInfomationInterface")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                ShowEmployeeInfomationInterface pUI = new ShowEmployeeInfomationInterface();
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            label1.Text = "Logged in as : " + User.CurrentUserName;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            User.LogObj.clearText();
            User.LogObj.Show();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ChangePasswordInterface>().Any())
            {
                User.ChangePassObj.Select();
            }
            else
            {
                User.ChangePassObj = new ChangePasswordInterface();
                opened.Add(User.ChangePassObj);
                User.ChangePassObj.Show();
            }
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.InventoryManagement.MainWindow")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                InventoryManagement.MainWindow pUI = new InventoryManagement.MainWindow(User.CurrentUserName, User.UserType, User.UserShop);
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.ReportUI")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                ReportUI pUI = new ReportUI();
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            User.LogObj.clearText();
            User.LogObj.Show();
            foreach (Form form in opened)
            {
                if (!form.Equals(this))
                    form.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Desktop\PharmacyManagement\PharmacyManagement\Resources\Admin-Help.pdf");
        }
    }
}
