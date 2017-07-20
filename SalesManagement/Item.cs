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
    class Item
    {   
        string product_code;
        string product;
        string quantity;
        string price;
        string total;
        
        public Item(string product_code, string product, string quantity, string price, string total)
        {
            this.product_code = product_code;
            this.product = product;
            this.quantity = quantity;
            this.price = price;
            this.total = total;
        }

        
    }
}
