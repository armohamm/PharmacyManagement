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
    public partial class ReturnItemUI : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        string returnDetails = "";

        private string username;
        private int shop;
        
        public ReturnItemUI(string username, string shop)
        {
            InitializeComponent();
            this.username = username;
            if (shop == "Shop1")
                this.shop = 1;
            if (shop == "Shop2")
                this.shop = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            logtxt.Text = logtxt.Text + "   " + username;

            try 
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT invoice_number, user, shop, details, date, time FROM pharmacy_management.invoice where shop = '"+ shop +"'  ",connection);
                connection.Open();
                DataSet ds= new DataSet();
                adapter.Fill(ds,"invoice");
                dataGridView1.DataSource=ds.Tables["invoice"];
                connection.Close();

            }catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txt_invoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch !=8 && ch != 46){
                e.Handled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {   
                
            string newstring  = returnDetails.Remove(0,1);

            try
            {
                Return retrn = new Return(txt_invoiceNo.Text, newstring);
                retrn.execute(username,shop, dataGridView3);
                dataGridView2.Enabled = false;
                dataGridView3.Enabled = false;
                btn_update.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                connection.Close();
            }
            returnDetails = "";
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            txt_invoiceNo.Text = null;

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT invoice_number, user, shop, details, date, time FROM pharmacy_management.invoice where shop = '" + shop + "'  ", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "invoice");
                dataGridView1.DataSource = ds.Tables["invoice"];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }



        private void txt_invoiceNo_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT invoice_number, user, shop, details, date, time FROM pharmacy_management.invoice WHERE shop = '" + shop + "'  AND invoice_number LIKE '" + txt_invoiceNo.Text + "%'";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter2.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.Columns[e.ColumnIndex].Name=="Remove")
            {
                dataGridView2.Rows.RemoveAt(this.dataGridView2.Rows[e.RowIndex].Index);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                try
                {
                    string returnedPcode =Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value);
                    string returnedPname =Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex+2].Value);
                    string returnedPQuntity =Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex+3].Value);
                    string returnedPrice =Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex+4].Value);
                    string returnedTotal =Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex+5].Value);

                    string returnProduct =returnedPcode+" "+returnedPname+" "+returnedPQuntity+" "+returnedPrice+" "+returnedTotal;

                    returnDetails=returnDetails+"/"+returnProduct;
                  

                    string[]  detailLst ={"Restore",returnedPcode,returnedPname,returnedPQuntity,returnedPrice,returnedTotal};
                    dataGridView3.Rows.Add(detailLst);
                }catch(Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                try 
                {
                    string restoredPcode =Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value);
                    string restoredPname =Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex+2].Value);
                    string restoredPQuntity =Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex+3].Value);
                    string restoredPrice =Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex+4].Value);
                    string restoredTotal =Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex+5].Value);

                    string restoredProduct =restoredPcode+" "+restoredPname+" "+restoredPQuntity+" "+restoredPrice+" "+restoredTotal;

                    string newreturnDetails ="";
                    string[] returnProductsLst =returnDetails.Split('/');
                    returnProductsLst=returnProductsLst.Where(s=>s != restoredProduct).ToArray();

                    int i =returnProductsLst.Length;
                    for(int j=0 ; j<i; j++)
                    {
                        if(j==0)
                        {
                            newreturnDetails=newreturnDetails+returnProductsLst[j];

                        }else
                        {
                            newreturnDetails=newreturnDetails+"/"+returnProductsLst[j];
                        }
                    }
                    returnDetails=newreturnDetails;

                    string[] showdetailLst = {"Remove",restoredPcode, restoredPname,restoredPQuntity,restoredPrice,restoredTotal};
                    dataGridView2.Rows.Add(showdetailLst);

                    if(dataGridView3.Columns[e.ColumnIndex].Name=="Restore")
                    {
                        dataGridView3.Rows.RemoveAt(this.dataGridView3.Rows[e.RowIndex].Index);
                    }


                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();

            string invoice_details_str = "";
            string number = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView2.Enabled = true;
                dataGridView3.Enabled = true;
                btn_update.Enabled = true;

                
                
                invoice_details_str = Convert.ToString(row.Cells[3].Value);
                number = Convert.ToString(row.Cells[0].Value);
                txt_invoiceNo.Text = number;

                string[] invoiceLst = invoice_details_str.Split('/');

                try
                {
                    int i = 0;
                    foreach (string deatils in invoiceLst)
                    {
                        String[] detailLst = deatils.Split();
                        dataGridView2.Rows.Add();
                        int j = 1;
                        foreach (string detail in detailLst)
                        {
                            dataGridView2.Rows[i].Cells[j].Value = detail;
                            j++;
                        }
                        i++;

                    }
                    dataGridView2.Rows.RemoveAt(dataGridView2.Rows.Count - 1);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\Users\Dilantha\Desktop\PharmacyManagement\PharmacyManagement\Resources\returnItems.pdf");
        }
    }
}
