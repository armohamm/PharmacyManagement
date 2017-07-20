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
    class Report
    {
        public void salesReprot(string fulldate, DataGridView dataGridView, DataGridView dataGridView5)
        {
           

            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = true;
            ws.Columns.AutoFit();
            
            int x = 6;
            int y = 1;
            ws.Cells[1, 6] = "RANDIMA PHARMCY";
            ws.Cells[2, 9] = "DATE :";
            ws.Cells[2, 10] = fulldate;
            ws.Cells[3, 1] = "SALES";
            ws.Cells[5, 1] = "Invoice_number";
            ws.Cells[5, 2] = "User";
            ws.Cells[5, 3] = "Shop";
            ws.Cells[5, 4] = "Time";
            ws.Cells[5, 5] = "Product Code";
            ws.Cells[5, 6] = "Product";
            ws.Cells[5, 7] = "Quantity";
            ws.Cells[5, 8] = "Price";
            ws.Cells[5, 9] = "Total";
            ws.Cells[5, 10] = "Sub Total";

            double netamount = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                ws.Cells[x, y] = row.Cells[0].Value;
                ws.Cells[x, ++y] = row.Cells[1].Value.ToString();
                ws.Cells[x, ++y] = row.Cells[2].Value.ToString();
                ws.Cells[x, ++y] = row.Cells[5].Value.ToString();
                int iny = ++y;
                double total = 0;
                string[] temp = row.Cells[3].Value.ToString().Split('/');
                foreach (string item in temp)
                {
                    if (item != "")
                    {
                        string[] temp2 = item.Split(' ');
                        foreach (string item2 in temp2)
                        {
                            ws.Cells[x, y] = item2;
                            y++;

                        }
                        total += Convert.ToDouble(temp2[4]);
                        y = iny;
                        x++;
                        
                    }

                }
                ws.Cells[x++, 10] = Convert.ToString(total);
                netamount += total;
                y = 1;
            }
            y += 9;
            ws.Cells[x, y-1] = "AMOUNT";
            ws.Cells[x, y] = Convert.ToString(netamount);

            x += 2;
            ws.Cells[x, 1] = "RETURNED SALES";
            x += 2;
            ws.Cells[x, 1] = "Invoice_number";
            ws.Cells[x, 2] = "User";
            ws.Cells[x, 3] = "Shop";
            ws.Cells[x, 4] = "Time";
            ws.Cells[x, 5] = "Product Code";
            ws.Cells[x, 6] = "Product";
            ws.Cells[x, 7] = "Quantity";
            ws.Cells[x, 8] = "Price";
            ws.Cells[x, 9] = "Total";
            ws.Cells[x, 10] = "Sub Total";
            x++;
            y = 1;

            double returnednetamount = 0;
            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                ws.Cells[x, y] = row.Cells[0].Value;
                ws.Cells[x, ++y] = row.Cells[1].Value.ToString();
                ws.Cells[x, ++y] = row.Cells[2].Value.ToString();
                ws.Cells[x, ++y] = row.Cells[5].Value.ToString();
                int iny = ++y;
                double total = 0;
                string[] retdetails = row.Cells[3].Value.ToString().Split('/');
                foreach (string item in retdetails)
                {
                    if (item != "")
                    {
                        string[] retdetails2 = item.Split(' ');
                        foreach (string item2 in retdetails2)
                        {
                            ws.Cells[x, y] = item2;
                            y++;

                        }
                        total += Convert.ToDouble(retdetails2[4]);
                        y = iny;
                        x++;

                    }

                }
                ws.Cells[x++, 10] = Convert.ToString(total);
                returnednetamount += total;
                y = 1;
            }
            y += 9;
            ws.Cells[x, y - 1] = "AMOUNT";
            ws.Cells[x, y] = Convert.ToString(returnednetamount);

            double finaltot = (netamount - returnednetamount);
            x += 2;
            ws.Cells[x, y - 3] = "NET TOTAL FOR THE DAY     =";
            ws.Cells[x, y] = Convert.ToString(finaltot);
        }

        public void stockReport(string date, DataGridView dataGridView2)
        {
            string fulldate = date; 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = true;

            ws.Cells[1, 6] = "RANDIMA PHARMCY";
            ws.Cells[2, 1] = "STOCK REPORT";
            ws.Cells[2, 11] = "DATE :";
            ws.Cells[2, 12] = fulldate;
            ws.Cells[4, 1] = "User";
            ws.Cells[4, 2] = "Product_Code";
            ws.Cells[4, 3] = "Stock_id";
            ws.Cells[4, 4] = "Status";
            ws.Cells[4, 5] = "Date";
            ws.Cells[4, 6] = "Time";
            ws.Cells[4, 7] = "Vendor";
            ws.Cells[4, 8] = "Exp_Date";
            ws.Cells[4, 9] = "Size";
            ws.Cells[4, 10] = "Shop";
            ws.Cells[4, 11] = "Cost_price";
            ws.Cells[4, 12] = "Unit_price";

            int z = 5;
            for (int j = 0; j < dataGridView2.Rows.Count; j++)
            {

                for (int i = 1; i <= 12; i++)
                {

                    ws.Cells[z, i] = dataGridView2.Rows[j].Cells[i - 1].Value + string.Empty;

                }
                z++;
            }
        }
    }
}
