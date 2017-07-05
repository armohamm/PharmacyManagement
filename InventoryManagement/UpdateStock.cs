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
    public partial class UpdateStock : Form
    {
        String user;
        String product_code;
        String stock_id;
        String vendor;
        String exp_date;
        String size;
        String cost_price;
        String unit_price;
        int shop;

        public UpdateStock(String user, String product_code, String stock_id, String vendor, String exp_date, String size, String cost_price, String unit_price, int shop)
        {
            InitializeComponent();
            this.product_code = product_code;
            this.stock_id = stock_id;
            this.vendor = vendor;
            this.exp_date = exp_date;
            this.size = size;
            this.cost_price = cost_price;
            this.unit_price = unit_price;
            this.shop = shop;
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product(product_code);
            Stock stock = new Stock(stock_id, Convert.ToInt32(size), shop);

            product.updateStock(user, stock, textBox3.Text, dateTimePicker1.Text, Convert.ToInt32(numericUpDown1.Value), textBox4.Text, textBox5.Text);

            this.Close();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            label3.Text = product_code;
            label4.Text = stock_id;
            textBox3.Text = vendor;
            dateTimePicker1.Value = DateTime.Parse(exp_date);
            numericUpDown1.Value = Convert.ToInt32(size);
            textBox4.Text = unit_price;
            textBox5.Text = cost_price;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String formattedDate(String date)
        {
            String[] arr = date.Split('/');
            String temp = arr[2];
            arr[2] = arr[1];
            arr[1] = arr[0];
            arr[0] = temp;
            return String.Join("-", arr);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0 && numericUpDown1.Value > 0 && isDigitsOnly(textBox4.Text) && isDigitsOnly(textBox5.Text))
                button1.Enabled = true;
            else
                button1.Enabled = false;
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
                    count = count + 1;
                    if (count > 1)
                        return false;
                }
            }
            return true;
        }
    }
}
