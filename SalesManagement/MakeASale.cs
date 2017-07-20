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
    public partial class MakeASale : Form 
    {   
        
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        private string user_name;
        private int shop;

        public MakeASale(string user_name, String shop)
        {
            InitializeComponent();
            this.user_name = user_name;
            if (shop == "Shop1")
                this.shop = 1;
            if (shop == "Shop2")
                this.shop = 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillData();
            dscnttxt.Text = "0";
            dataGridView2.ReadOnly = true;
            dataGridView1.ReadOnly = true;
            logtxt.Text = logtxt.Text + "   " + user_name;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                Addbttn.Enabled = false;
                

            }
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Remove"){
                dataGridView1.Rows.RemoveAt(this.dataGridView1.Rows[e.RowIndex].Index);

            }

        }
        private void fillData()
        {
            
            string selectQuery = "SELECT product_code, name, description, category, stock_shop_" + shop + ",unit_price, re_order_size  FROM pharmacy_management.product ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void Addbttn_Click(object sender, EventArgs e)
        {
            if (quantitytxt.Text == "" || pnametxt.Text == "" || pcodetxt.Text == "" || pricetxt.Text == "" || dscnttxt.Text == "")
            {
                MessageBox.Show("Please fill the Required Fields properly!!!");
                pcodetxt.Text = null;
                pnametxt.Text = null;
                quantitytxt.Text = null;
                pricetxt.Text = null;
                return;
            }

            string selectedpname;
            string selectedprice;
            string total;
            string valuewithoutdiscount;
            string selectedpcode;

            selectedpname = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            selectedpcode = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            string stock = Convert.ToString(dataGridView2.CurrentRow.Cells[4].Value);
            int value = Convert.ToInt32(stock) - Convert.ToInt32(quantitytxt.Text);

            if (value < 0)
            {
                MessageBox.Show(selectedpname + "'s stock is too low!!!");
                pnametxt.Text = null;
                pcodetxt.Text = null;
                quantitytxt.Text = null;
                dscnttxt.Text = "0";
                pricetxt.Text = null;
                pcodetxt.Enabled = true;
                pnametxt.Enabled = true;

                return;
            }
            selectedprice = pricetxt.Text;
            valuewithoutdiscount = Convert.ToString(Convert.ToDouble(selectedprice)*Convert.ToDouble(quantitytxt.Text));
            total = Convert.ToString(Convert.ToDouble(valuewithoutdiscount) - ((Convert.ToDouble(dscnttxt.Text) / 100) * Convert.ToDouble(valuewithoutdiscount)));
            dataGridView1.Rows.Add(" ", selectedpcode, selectedpname, quantitytxt.Text, selectedprice, total );
            RMVALLBttn.Enabled = true;
            addPrice();

            pnametxt.Text = null;
            pcodetxt.Text = null;
            quantitytxt.Text = null;
            dscnttxt.Text = "0";
            pricetxt.Text = null;
            pcodetxt.Enabled = true;
            pnametxt.Enabled = true;

            

            

       
        }

        private void Totaltxt_TextChanged(object sender, EventArgs e)
        {
        }
        void addPrice()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            Totaltxt.Text = sum.ToString();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void quantitytxt_TextChanged(object sender, EventArgs e)
        {
        }
    
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            pnametxt.Text = selectedRow.Cells[1].Value.ToString();
            string selectedpcode;
            selectedpcode = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            pcodetxt.Text = selectedpcode;
            pricetxt.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[5].Value);*/
        }


        private void pnametxt_TextChanged(object sender, EventArgs e)
        {
            if (pnametxt.Text != "")
            {
                try
                {
                    connection.Open();
                    string query = "SELECT product_code, name, description, category, stock_shop_" + shop + ",unit_price, re_order_size  FROM pharmacy_management.product WHERE name LIKE '" + pnametxt.Text + "%'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt2 = new DataTable();
                    adapter.Fill(dt2);
                    dataGridView2.DataSource = dt2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                //DataView dv = new DataView(dt);
                //dv.RowFilter = string.Format("name LIKE '{0}%'", pnametxt.Text);
                //dataGridView2.DataSource = dv;
                pcodetxt.Enabled = false;
            }
            else
            {
                fillData();
                pcodetxt.Enabled = true;
            }

        }

        private void pcodetxt_TextChanged(object sender, EventArgs e)
        {
            if (pcodetxt.Text != "")
            {
                try
                {
                    connection.Open();
                    string query = "SELECT product_code, name, description, category, stock_shop_" + shop + ",unit_price, re_order_size  FROM pharmacy_management.product WHERE product_code LIKE '" + pcodetxt.Text + "%'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt2 = new DataTable();
                    adapter.Fill(dt2);
                    dataGridView2.DataSource = dt2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                //DataView dv = new DataView(dt);
                //dv.RowFilter = string.Format("CONVERT(`product_code`, 'System.String') LIKE '{0}%'", pcodetxt.Text);
                //dataGridView2.DataSource = dv;
                pnametxt.Enabled = false;
            }
            else
            {  
                fillData();
                pnametxt.Enabled = true;
            }
                
        }

        private void RMVALLBttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(" Table is already empty");
            }
            else
            {
                dataGridView1.Rows.Clear();
                Totaltxt.Text = null;
            }
        }

        private void dscnttxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void MASBttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Please add some Items first!!!");
            }
            else
            {
                string amount = Totaltxt.Text;
                Sale sale = new Sale();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string pcode = row.Cells[1].Value.ToString();
                    string product = row.Cells[2].Value.ToString();
                    string quantity = row.Cells[3].Value.ToString();
                    string price = row.Cells[4].Value.ToString();
                    string total = row.Cells[5].Value.ToString();

                    Item item = new Item(pcode, product, quantity, price, total);
                    sale.add(item);
                }
                sale.execute(dataGridView1, dataGridView2, Totaltxt.Text, user_name, shop);


                Addbttn.Enabled = false;
                dataGridView1.DataSource = null;
                dataGridView1.DataBindings.Clear();
                Totaltxt.Text = null;
            }
            
            /*for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string currentstock = "";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT stock FROM sampleinventory.product WHERE product_code = '" + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + "'";

                try
                {
                    connection.Open();
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        currentstock = Convert.ToString(Convert.ToInt32(myReader.GetString("stock")));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

      
                string newstock = Convert.ToString(Convert.ToInt32(currentstock) - Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                string updatequery = "UPDATE sampleinventory.product SET stock = '" + newstock + "' WHERE name = '" + Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + "' ";
                MySqlCommand cmdsampleinventory = new MySqlCommand(updatequery, connection);
                try
                {
                    connection.Open();
                    int myread2er = cmdsampleinventory.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            string details = "";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string product_code = "";
                string product = "";
                string quantity = "";
                string price = "";
                string total = "";

                product_code = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                product = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                quantity = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                price = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                total = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);

                details += product_code + " " + product + " " + quantity + " " + price + " " + total + "/" ;
            }
            try
            {
                DateTime current = DateTime.Now;
                string date = "";
                string time = "";

                date = current.ToShortDateString();
                time = current.ToLongTimeString();
                connection.Open();
                string insertquery = "INSERT INTO sampleinventory.invoice VALUES (null,@details,@date,@time)";
                MySqlCommand command = new MySqlCommand(insertquery, connection);
                command.Parameters.AddWithValue("@details", details);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time", time);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
            Form2 frm = new Form2();
            for (int i = 0; i < dataGridView1.RowCount-1; i++ )
            {
                frm.dataGridView3.Rows.Add();
                for (int j = 2 ; j < 6 ; j++)
                {
                    frm.dataGridView3.Rows[i].Cells[j-2].Value = this.dataGridView1.Rows[i].Cells[j].Value;
                    //MessageBox.Show(Convert.ToString(this.dataGridView1.Rows[i].Cells[j].Value));
                }
                
            }

            MySqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "SELECT * FROM sampleinventory.invoice WHERE invoice_number = (SELECT MAX(invoice_number) FROM sampleinventory.invoice)";
            string invoice_num = "";
            try
            {
                connection.Open();
                MySqlDataReader myReader2 = cmd2.ExecuteReader();
                while (myReader2.Read())
                {
                    invoice_num = Convert.ToString(Convert.ToInt32(myReader2.GetString("Invoice_number")));
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            frm.invcnumtxtx.Text = invoice_num;
            frm.ttlbilltxt.Text = Totaltxt.Text;
            frm.Show();*/


        }

        private void Exitbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            string name = "";
            string code = "";
            string price = ""; 
            foreach (DataGridViewRow row in dataGridView2.SelectedRows){

                name = Convert.ToString(row.Cells[1].Value);
                code = Convert.ToString(row.Cells[0].Value);
                price = Convert.ToString(row.Cells[5].Value);
                pnametxt.Text = name;
                pcodetxt.Text = code;
                pricetxt.Text = price;
            }
            pnametxt.Enabled = true;
            pcodetxt.Enabled = true;

            
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {
            if (isDigitOnly(pricetxt.Text))
            {
                Addbttn.Enabled = true;
            }
            else
            {
                Addbttn.Enabled = false;
            }
        }
        private bool isDigitOnly(string str)
        {   
            if(str.Length == 0)
            {
                return false;
            }
            int count = 0;
            foreach(char c in str)
            {
                if((c < '0' || c > '9') && c != '.')
                {
                    return false;
                }
                if(c == '.')
                {
                    count += 1;
                    if(count > 1)
                        return false;
                }
            }
            try
            {
                string temp = str.Split('.')[1];
                if(temp.Length > 2)
                    return false;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void pcodetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
 
        }

        /*private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
            
        }*/

        private void quantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dscnttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Desktop\PharmacyManagement\PharmacyManagement\Resources\Help.pdf");
        
        }
     
    }
}
