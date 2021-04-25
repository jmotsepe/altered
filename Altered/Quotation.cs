using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Altered
{
    class Quotation
    {        

        public string Quote_number { get; }
        public string CustomerID { get; }
        public DateTime Quote_date { get; }
        public double Quote_total { get; }
        public DataGridView ItemDGV { get; }

        public Quotation(string quote_number, string customerID, DateTime quote_date, double quote_total, DataGridView itemDGV)
        {
            Quote_number = quote_number;
            CustomerID = customerID;
            Quote_date = quote_date;
            Quote_total = quote_total;
            ItemDGV = itemDGV;

            CommitQuotation();
        }        

        private void CommitQuotation()
        {
            string quoteStoredProc = "sp_insertQuotations";
            string itemsStoredProc = "sp_insertQuote_Items";


            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(quoteStoredProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@quote_number", SqlDbType.VarChar).Value = Quote_number;
                    cmd.Parameters.AddWithValue("@customerID", SqlDbType.VarChar).Value = CustomerID;
                    cmd.Parameters.AddWithValue("@quote_date", SqlDbType.DateTime).Value = Quote_date;
                    cmd.Parameters.AddWithValue("@quote_total", SqlDbType.VarChar).Value = Quote_total;

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
                        cmd.Parameters.AddWithValue("@quote_number", SqlDbType.VarChar).Value = Quote_number;
                        cmd.Parameters.AddWithValue("@quantity", SqlDbType.Int).Value = int.Parse(row.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@productID", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
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
                    MessageBox.Show("Quote Captured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }


    }
}
