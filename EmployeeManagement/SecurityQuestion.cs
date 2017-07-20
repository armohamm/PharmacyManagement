using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.EmployeeManagement
{
    public partial class SecurityQuestion : Form
    {
        public SecurityQuestion()
        {
            InitializeComponent();
        }

        private void SecurityQuestion_Load(object sender, EventArgs e)
        {
            questionTxt.Text = User.showSecurityQuestion();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            User.checkAnswer(answertxt.Text);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
