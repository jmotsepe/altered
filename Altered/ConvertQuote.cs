using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Altered
{
    class ConvertQuote
    {
        private string Quote_number { get; set; }
        private string CustomerID { get; set; }
        private string Quote_date { get; set; }
        private string QueryItems { get; set; }
        private string Query { get; set; }
        private string SendorPrint { get; set; }
        private string EmailAddress = "";

        public ConvertQuote()
        {

        }

        public ConvertQuote(string quote_number, string customerID, string quote_date, string query, string queryItems, string emailPrint)
        {
            Quote_number = quote_number;
            CustomerID = customerID;
            Quote_date = quote_date;
            Query = query;
            QueryItems = queryItems;
            SendorPrint = emailPrint;

            CreateQuote();
        }

        Microsoft.Office.Interop.Excel.Application excelApplication;
        Workbook excelWorkbook;
        Worksheet excelWorksheet;

        private void CreateQuote()
        {
            string path = "C:\\Program Files (x86)\\TMTech Solutions\\Altered EMS\\QuoteTemplate.xlsx";
            //string path = "C:\\Users\\Admin\\source\\repos\\Altered\\Altered\\QuoteTemplate.xlsx";
            excelApplication = new Microsoft.Office.Interop.Excel.Application
            {
                Visible = false
            };

            excelWorkbook = excelApplication.Workbooks.Open(path);
            excelWorksheet = (Worksheet)excelWorkbook.ActiveSheet;

            string[,] customerData = new string[7, 1];
            char registered = 'N';

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            if (sdr["company"].ToString() != "")
                            {
                                excelWorksheet.get_Range("B12").Value2 = sdr["company"].ToString();
                            }
                            else
                            {
                                excelWorksheet.get_Range("B12").Value2 = sdr["rep_name"].ToString();
                            }

                            if (sdr["telephone"].ToString() != "")
                            {
                                excelWorksheet.get_Range("B13").Value2 = sdr["telephone"].ToString();
                            }
                            else
                            {
                                excelWorksheet.get_Range("B13").Value2 = sdr["cellphone"].ToString();
                            }
                            excelWorksheet.get_Range("B14").Value2 = sdr["email"].ToString();
                            excelWorksheet.get_Range("B15:E16").Value2 = sdr["address"].ToString();
                            excelWorksheet.get_Range("B17").Value2 = sdr["postal_code"].ToString();

                            EmailAddress = sdr["email"].ToString();
                            registered = char.Parse(sdr["registered"].ToString());


                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.Message, "Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                DataSet ds = new DataSet();
                System.Data.DataTable dt = new System.Data.DataTable();
                int rowIndex = 21;

                using (SqlCommand cmd = new SqlCommand(QueryItems, con))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(ds);
                            ds.Tables.Add(dt);
                            var rows = ds.Tables[0].Rows;
                            int rowCount = rows.Count;
                            string[,] invoiceRows = new string[rowCount, 9];

                            foreach (DataRow row in rows)
                            {
                                for (int i = 0; i < rowCount; i++)
                                {
                                    invoiceRows[i, 0] = row["Quantity"].ToString();
                                    invoiceRows[i, 1] = row["Description"].ToString();
                                    invoiceRows[i, 2] = "";
                                    invoiceRows[i, 3] = "";
                                    invoiceRows[i, 4] = "";
                                    invoiceRows[i, 5] = "";
                                    invoiceRows[i, 6] = "";
                                    invoiceRows[i, 7] = "";
                                    invoiceRows[i, 8] = "";
                                }

                                excelWorksheet.get_Range("A" + rowIndex + ":I" + rowIndex).Value2 = invoiceRows;
                                excelWorksheet.get_Range("A" + rowIndex + ":K" + rowIndex).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                                excelWorksheet.get_Range("J" + rowIndex).Value2 = float.Parse(row["Price"].ToString());
                                excelWorksheet.get_Range("K" + rowIndex).Value2 = float.Parse(row["Total"].ToString());
                                excelWorksheet.get_Range("J" + rowIndex + ":K" + rowIndex).NumberFormat = "[$R-en-ZA] # ##0.00";
                                rowIndex++;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                con.Close();
            }

            string valid_until = DateTime.Parse(Quote_date).AddDays(14).ToString();
            excelWorksheet.get_Range("J5").Value2 = Quote_date;
            excelWorksheet.get_Range("J6").Value2 = Quote_number;
            excelWorksheet.get_Range("J7").Value2 = CustomerID;
            excelWorksheet.get_Range("J8").Value2 = valid_until;
            excelWorksheet.get_Range("C44").Value2 = Quote_number;
            //excelWorksheet.get_Range("K39").NumberFormat = "[$R-en-ZA] # ##0.00";
            if (registered == 'Y')
            {
                excelWorksheet.get_Range("K39").Formula = "=K37 * 0.15";
            }
            else
            {
                excelWorksheet.get_Range("K39").Formula = 0;
            }

            string location = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents\\");
            string pdfFile = location + Quote_number + ".pdf";
            string excelFile = location + Quote_number + ".xlsx";
            excelApplication.UserControl = false;

            if (File.Exists(pdfFile))
            {
                File.Delete(pdfFile);
            }
            if (File.Exists(excelFile))
            {
                File.Delete(excelFile);
            }

            excelWorkbook.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, pdfFile);

            if (SendorPrint == "Print")
            {
                excelWorksheet.PrintOutEx(Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                System.Diagnostics.Process.Start(pdfFile);
            }
            else if (SendorPrint == "Email")
            {
                if (EmailAddress == "")
                {
                    _ = MessageBox.Show("Quote cannot be emailed, client is missing email details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _ = new SendEmail(Quote_number, EmailAddress);
                }
            }


            //Cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(excelWorksheet);

            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(excelWorkbook);

            excelApplication.Quit();
            Marshal.FinalReleaseComObject(excelApplication);
            File.Delete(excelFile);
        }

    }
}
