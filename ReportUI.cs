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
using System.Collections;
using Microsoft.Office.Interop.Excel;

namespace PharmacyManagement
{
    public partial class ReportUI : Form
    {
        string fulldate = "";

        public ReportUI()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            comboBox1.SelectedIndex = 1;
            fillData();
        }

        public void fillData()
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

            string selectQuery = "SELECT * FROM pharmacy_management.invoice ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            string returnselectQuery = "SELECT * FROM pharmacy_management.return_table ";
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(returnselectQuery, connection);
            System.Data.DataTable dt2 = new System.Data.DataTable();
            adapter2.Fill(dt2);
            dataGridView4.DataSource = dt2;

            string selectQuery2 = "SELECT * FROM pharmacy_management.report ";
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery2, connection);
            System.Data.DataTable dt3 = new System.Data.DataTable();
            adapter3.Fill(dt3);
            dataGridView.DataSource = dt3;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String shop = "";
            if (comboBox1.SelectedIndex == 0)
                shop = "1' OR shop LIKE '2";
            if (comboBox1.SelectedIndex == 1)
                shop = "1";
            if (comboBox1.SelectedIndex == 2)
                shop = "2";

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

            string wholedate = dateTimePicker1.Text;
            string[] dates = wholedate.Split('-');

            string year = dates[0];
            string month = dates[1];
            if (Convert.ToUInt32(month) < 10)
            {
                month = month[1].ToString();
            }
            string date = dates[2];
            if (Convert.ToUInt32(date) < 10)
            {
                date = date[1].ToString();
            }

            fulldate = month + "/" + date + "/" + year;

            string query = "SELECT * FROM pharmacy_management.invoice WHERE date LIKE '" + fulldate + "' AND shop LIKE '" + shop + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            System.Data.DataTable dt2 = new System.Data.DataTable();
            adapter.Fill(dt2);
            dataGridView1.DataSource = dt2;
            dataGridView2.DataSource = dt2;

            string returnquery = "SELECT * FROM pharmacy_management.return_table WHERE date LIKE '" + fulldate + "' AND shop LIKE '" + shop + "'";
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(returnquery, connection);
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter2.Fill(dt);
            dataGridView4.DataSource = dt;
            dataGridView5.DataSource = dt;

            string yeart = dates[0];
            string montht = dates[1];
            string day = dates[2];
            fulldate = day + "/" + montht + "/" + yeart;

            string queryt = "SELECT * FROM pharmacy_management.report WHERE date LIKE '" + fulldate + "'";
            MySqlDataAdapter adaptert = new MySqlDataAdapter(queryt, connection);
            System.Data.DataTable dt2t = new System.Data.DataTable();
            adaptert.Fill(dt2t);
            dataGridView.DataSource = dt2t;
            dataGridView3.DataSource = dt2t;
        }

        private void enterbttn_Click(object sender, EventArgs e)
        {
            string date = fulldate;
            Report report = new Report();
            report.salesReprot(date, dataGridView2, dataGridView5);
        }

        private void clsebttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report report2 = new Report();
            report2.stockReport(fulldate, dataGridView3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Desktop\PharmacyManagement\PharmacyManagement\Resources\Help1.pdf");
        }
    }
}
