﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagement.InventoryManagement
{
    class Product
    {
        private String product_code;
        private MySqlConnection mySqlConn;

        public Product(String product_code)
        {
            this.product_code = product_code;

        }

        public void addProduct(String name, String description, String category, int re_order_size, String unit_price)
        {

            mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("insert into pharmacy_management.product (product_code, name, description, category, re_order_size, unit_price) values ('" + product_code + "','" + name + "','" + description + "','" + category + "','" + re_order_size + "','" + unit_price + "') ", mySqlConn);
            MySqlDataReader dataReader;
            try
            {
                mySqlConn.Open();
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) { }

                MessageBox.Show("Product added successfully");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }

        }

        public void updateProduct(String description, String category, int re_order_size, String unit_price)
        {
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("update product set description = '" + description + "', category = '" + category + "', unit_price = '" + unit_price + "', re_order_size = '" + re_order_size + "' where product_code = '" + product_code + "'", mySqlConn);

            try
            {
                mySqlConn.Open();
                int numRowsUpdated = command.ExecuteNonQuery();
                MessageBox.Show("Data Updated");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        public void addStock(String user, Stock stock)
        {
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("insert into pharmacy_management.stock (product_code, stock_id, vendor, exp_date, entered_date, size, shop, cost_price, unit_price) values ('" + product_code + "','" + stock.getStockID() + "','" + stock.getVendor() + "','" + formattedDate(stock.getExpDate()) + "','" + formattedDate(DateTime.Today.ToString("MM/dd/yyyy")) + "','" + stock.getSize() + "','" + stock.getShop() + "','" + stock.getUnitPrice() + "','" + stock.getCostPrice() + "') ", mySqlConn);
            MySqlDataReader dataReader;
            try
            {
                mySqlConn.Open();
                dataReader = command.ExecuteReader();

                while (dataReader.Read()) { }

                dataReader.Close();
                MessageBox.Show("Stock added successfully");

                StockReport stockReport = new StockReport();
                stockReport.addToReport(user, product_code, stock.getStockID(), "added", stock.getVendor(), stock.getExpDate(), stock.getSize(), stock.getShop(), stock.getCostPrice(), stock.getUnitPrice());
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
            }

            int size = 0;
            command = new MySqlCommand("select stock_shop_" + stock.getShop()+  " from product where product_code = '" + product_code + "'", mySqlConn);
            try
            {
                mySqlConn.Open();
                MySqlDataReader datReader = command.ExecuteReader();
                while (datReader.Read())
                {
                    size = Convert.ToInt32(datReader.GetString("stock_shop_" + stock.getShop()));
                }

                datReader.Close();
                MySqlCommand command2 = new MySqlCommand("update product set stock_shop_" + stock.getShop() + " = '" + (stock.getSize() + size) + "' where product_code = '" + product_code + "'", mySqlConn);
                int numRowsUpdated = command2.ExecuteNonQuery();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        public void returnStock(String user, Stock stock, int remStock)
        {
            int stock_size = 0;
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select stock_shop_" + stock.getShop() + " from product where product_code = '" + product_code + "'", mySqlConn);
            try
            {
                mySqlConn.Open();
                MySqlDataReader datReader = command.ExecuteReader();
                while (datReader.Read())
                {
                    stock_size = Convert.ToInt32(datReader.GetString("stock_shop_" + stock.getShop()));
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
            }
            command = new MySqlCommand("update stock set status = 'returned', returned_date = '" + formattedDate(DateTime.Today.ToString("MM/dd/yyyy")) + "' where product_code = '" + product_code + "' and stock_id = '" + stock.getStockID() + "'", mySqlConn);
            MySqlCommand command2 = new MySqlCommand("update product set stock_shop_" + stock.getShop() + " = '" + (stock_size - (Convert.ToInt32(stock.getSize()) - remStock)) + "' where product_code = '" + product_code + "'", mySqlConn);
            
            try
            {
                mySqlConn.Open();
                int numRowsUpdated = command.ExecuteNonQuery();
                int numRowsUpdated2 = command2.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                InventoryManagement.StockReport stockReport = new InventoryManagement.StockReport();
                stockReport.addToReport(user, product_code, stock.getStockID(), "returned", stock.getVendor(), stock.getExpDate(), remStock, stock.getShop(), stock.getCostPrice(), stock.getUnitPrice());
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
        }

        public void updateStock(String user, Stock stock, String vendor, String exp_date, int size, String unit_price, String cost_price, int shop) 
        {
            int stock_size = 0;
            MySqlConnection mySqlConn = DBConnection.getConn();
            MySqlCommand command = new MySqlCommand("select stock_shop_" + shop + " from product where product_code = '" + product_code + "'", mySqlConn);
            try
            {
                mySqlConn.Open();
                MySqlDataReader datReader = command.ExecuteReader();
                while (datReader.Read())
                {
                    stock_size = Convert.ToInt32(datReader.GetString("stock_shop_" + shop));
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
            }

            command = new MySqlCommand("update stock set vendor = '" + vendor + "', exp_date = '" + formattedDate(exp_date) + "', size = '" + size + "', unit_price = '" + unit_price + "', cost_price = '" + cost_price + "' where product_code = '" + product_code + "' and stock_id = '" + stock.getStockID() + "'", mySqlConn);
            MySqlCommand command2 = new MySqlCommand("update product set stock_shop_" + shop + " = '" + (stock_size + size - stock.getSize()) + "' where product_code = '" + product_code + "'", mySqlConn);
            try
            {
                mySqlConn.Open();
                int numRowsUpdated = command.ExecuteNonQuery();
                int numRowsUpdated2 = command2.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                InventoryManagement.StockReport stockReport = new InventoryManagement.StockReport();
                stockReport.addToReport(user, product_code, stock.getStockID(), "updated", vendor, exp_date, size, shop, cost_price, unit_price);

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                mySqlConn.Close();
                DBConnection.returnConn(mySqlConn);
                mySqlConn = null;
            }
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
    }
}
