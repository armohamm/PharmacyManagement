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
    public partial class Invoice : Form
    {
        private string user_name;

        public Invoice(string user_name)
        {
            InitializeComponent();
            this.user_name = user_name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            logtxt.Text = logtxt.Text + "   " + user_name;
        }
    }
}
