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
    public partial class ChangePasswordInterface : Form
    {

        public ChangePasswordInterface()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            
            if (newPasswordTxt.Text == confirmNewPasswordTxt.Text)
            {
                //MessageBox.Show(userNameTxt.Text);
                //if(questionTxt.Text != "" && anserTxt.Text != "")
                    User.changePassword(currentPasswordTxt.Text, newPasswordTxt.Text,questionTxt.Text, anserTxt.Text);

            }
            else
                passNotMatchErLbl.Visible = true;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void showMessage(String message)
        {
            MessageBox.Show(message);
        }

        private void ChangePasswordInterface_Load(object sender, EventArgs e)
        {
            userNameTxt.Text = User.LogObj.getUserName();
            userNameTxt.ReadOnly = true;
            questionCheckBox.Checked = true;
            questionTxt.Text = User.getQuestion();
            anserTxt.Text = User.getAnswer();
        }

        public void clearText()
        {
            currentPasswordTxt.Clear();
            newPasswordTxt.Clear();
            confirmNewPasswordTxt.Clear();
        }

        private void confirmNewPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            passNotMatchErLbl.Visible = false;
        }

        private void currentPasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newPasswordTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void newPasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmNewPasswordTxt.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void confirmNewPasswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveBtn_Click(this, new EventArgs());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public void setCurrentPassword(String password)
        {
            currentPasswordTxt.Text = password;
            currentPasswordTxt.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (questionCheckBox.Checked)
            {
                questionLbl.Visible = true;
                questionTxt.Visible = true;
                answerLbl.Visible = true;
                anserTxt.Visible = true;
            }
        }

    }
}
