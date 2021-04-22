using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Altered
{
    internal class Order
    {
        private string OrderNumber { get; set; }
        private string SupplierID { get; set; }
        private DateTime OrderDate { get; set; }
        private DataGridView ItemDGV { get; set; }
        private string InvoiceNumber { get; set; }
        private DateTime? InvoiceDate { get; set; }

        public Order()
        {

        }

        public Order(string orderNumber, string supplierID, DateTime orderDate, DataGridView itemDGV, string invoiceNumber, DateTime? invoiceDate)
        {
            OrderNumber = orderNumber;
            SupplierID = supplierID;
            OrderDate = orderDate;
            ItemDGV = itemDGV;
            InvoiceNumber = invoiceNumber;
            InvoiceDate = invoiceDate;

            CommitOrder();
        }

        public Order(string orderNumber, string invoiceNumber, DateTime invoiceDate)
        {
            OrderNumber = orderNumber;
            InvoiceNumber = invoiceNumber;
            InvoiceDate = invoiceDate;

            UpdateOrder();
        }

        private void CommitOrder()
        {
            string storedProc = "sp_insertOrder";
            
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                //Insert the order details first
                using (SqlCommand cmd = new SqlCommand(storedProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = OrderNumber;
                    cmd.Parameters.AddWithValue("@supplierID", SqlDbType.VarChar).Value = SupplierID;
                    cmd.Parameters.AddWithValue("@order_date", SqlDbType.Date).Value = OrderDate;
                    cmd.Parameters.AddWithValue("@invoice_number", SqlDbType.VarChar).Value = InvoiceNumber;
                    cmd.Parameters.AddWithValue("@invoice_date", SqlDbType.Date).Value = InvoiceDate;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        CommitItems();
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString());
                    }
                }
                con.Close();
            }
        }

        private void CommitItems()
        {
            //Insert the order items
            string storedProc = "sp_insertOrderItems";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(storedProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (DataGridViewRow row in ItemDGV.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = OrderNumber;
                        cmd.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = row.Cells[1].Value.ToString();
                        cmd.Parameters.AddWithValue("@quantity", SqlDbType.Int).Value = int.Parse(row.Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@price", SqlDbType.Float).Value = double.Parse(row.Cells[2].Value.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString());
                        }
                    }
                    MessageBox.Show("Order placed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }        
        }

        private void UpdateOrder()
        {
            string storedproc = "sp_updateOrder";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(storedproc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = OrderNumber;
                    cmd.Parameters.AddWithValue("@invoice_number", SqlDbType.VarChar).Value = InvoiceNumber;
                    cmd.Parameters.AddWithValue("@invoice_date", SqlDbType.Date).Value = InvoiceDate;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                con.Close();
            }
        }
    }
}