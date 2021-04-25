using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Altered
{
    internal class Invoice
    {
        private string Invoice_number { get; set; }
        private string CustomerID { get; set; }
        private DateTime Invoice_date { get; set; }
        private char Paid { get; set; }
        private DateTime? Invoice_paid_date { get; set; }
        private double Invoice_total { get; set; }
        private DataGridView ItemDGV { get; set; }

        public Invoice()
        {

        }

        public Invoice(string invoice_number, string customerID, DateTime invoice_date, char paid, DateTime? invoice_paid_date, double invoice_total, DataGridView itemDGV)
        {
            Invoice_number = invoice_number;
            CustomerID = customerID;
            Invoice_date = invoice_date;
            Paid = paid;
            Invoice_paid_date = invoice_paid_date;
            Invoice_total = invoice_total;
            ItemDGV = itemDGV;

            CommitInvoice();
        }        

        public Invoice(string invoice_number, char paid, DateTime? invoice_paid_date)
        {
            Invoice_number = invoice_number;
            Paid = paid;
            Invoice_paid_date = invoice_paid_date;

            UpdateInvoice();
        }

        private void CommitInvoice()
        {
            string invoiceStoredProc = "sp_insertInvoice";
            string itemsStoredProc = "sp_insertInvoice_Items";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(invoiceStoredProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoice_number", SqlDbType.VarChar).Value = Invoice_number;
                    cmd.Parameters.AddWithValue("@customerID", SqlDbType.VarChar).Value = CustomerID;
                    cmd.Parameters.AddWithValue("@invoice_date", SqlDbType.DateTime).Value = Invoice_date;
                    cmd.Parameters.AddWithValue("@paid", SqlDbType.Char).Value = Paid;
                    cmd.Parameters.AddWithValue("@invoice_paid_date", SqlDbType.DateTime).Value = Invoice_paid_date;
                    cmd.Parameters.AddWithValue("@invoice_total", SqlDbType.VarChar).Value = Invoice_total;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (SqlCommand cmd = new SqlCommand(itemsStoredProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow row in ItemDGV.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@invoice_number", SqlDbType.VarChar).Value = Invoice_number;
                        cmd.Parameters.AddWithValue("@productID", SqlDbType.Int).Value = int.Parse(row.Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@quantity", SqlDbType.Int).Value = int.Parse(row.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@price", SqlDbType.Float).Value = double.Parse(row.Cells[3].Value.ToString().Substring(1));

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Invoice captured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();
            }
        }

        private void UpdateInvoice()
        {
            string storedProc = "sp_updateInvoice";
            using(SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using(SqlCommand cmd = new SqlCommand(storedProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@invoice_number", SqlDbType.VarChar).Value = Invoice_number;
                    cmd.Parameters.AddWithValue("@paid", SqlDbType.Char).Value = Paid;
                    cmd.Parameters.AddWithValue("@invoice_paid_date", SqlDbType.DateTime).Value = Invoice_paid_date;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch(SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}