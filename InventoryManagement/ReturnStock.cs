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
    public partial class ReturnStock : Form
    {
        String product_code = "";
        String stock_id = "";
        String size = "";
        public ReturnStock(String product_code, String stock_id, String size)
        {
            InitializeComponent();
            this.product_code = product_code;
            this.stock_id = stock_id;
            this.size = size;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product(product_code);
            Stock stock = new Stock(stock_id, Convert.ToInt32(size));

            product.returnStock(stock, Convert.ToInt32(numericUpDown1.Value));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
