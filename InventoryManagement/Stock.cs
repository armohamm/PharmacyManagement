using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.InventoryManagement
{
    class Stock
    {
        private String stock_id;
        private String vendor;
        private String exp_date;
        private int size;
        private int shop;
        private String cost_price;
        private String unit_price;

        public Stock(String stock_id, int size, int shop)
        {
            this.stock_id = stock_id;
            this.size = size;
            this.shop = shop;
            this.vendor = "";
            this.exp_date = "";
            this.cost_price = "";
            this.unit_price = "";
        }

        public Stock(String stock_id, String vendor, String exp_date, int size, int shop, String cost_price, String unit_price)
        {
            this.stock_id = stock_id;
            this.vendor = vendor;
            this.exp_date = exp_date;
            this.size = size;
            this.shop = shop;
            this.cost_price = cost_price;
            this.unit_price = unit_price;
        }

        public String getStockID()
        {
            return stock_id;
        }

        public String getVendor()
        {
            return vendor;
        }

        public int getSize()
        {
            return size;
        }

        public int getShop()
        {
            return shop;
        }

        public String getUnitPrice()
        {
            return unit_price;
        }

        public String getCostPrice()
        {
            return cost_price;
        }

        public String getExpDate()
        {
            return exp_date;
        }
    }
}
