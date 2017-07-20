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
    public partial class CashierInterface : Form
    {
        private FormCollection list;
        private List<Form> opened;

        public CashierInterface()
        {
            InitializeComponent();
            list = Application.OpenForms;
            opened = new List<Form>();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            User.LogObj.clearText();
            User.LogObj.Show();
        }

        private void searchItemBtn_Click(object sender, EventArgs e)
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
                InventoryManagement.SearchProduct pUI = new InventoryManagement.SearchProduct(User.CurrentUserName);
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void makeASaleBtn_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.MakeASale")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                MakeASale pUI = new MakeASale(User.CurrentUserName, User.UserShop);
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void CashierInterface_Load(object sender, EventArgs e)
        {
            label1.Text = "Logged in as : " + User.CurrentUserName;
        }

        private void CashierInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            User.LogObj.clearText();
            User.LogObj.Show();
            foreach (Form form in opened)
            {
                if (!form.Equals(this))
                    form.Close();
            }
        }

        private void returnItemBtn_Click(object sender, EventArgs e)
        {
            bool temp = true;
            foreach (Form form in list)
            {
                if (form.GetType().ToString() == "PharmacyManagement.ReturnItemUI")
                {
                    form.Select();
                    temp = false;
                }
            }
            if (temp)
            {
                ReturnItemUI pUI = new ReturnItemUI(User.CurrentUserName, User.UserShop);
                opened.Add(pUI);
                pUI.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Desktop\PharmacyManagement\PharmacyManagement\Resources\Cashier-Help.pdf");
        }
    }
}
