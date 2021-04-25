using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altered
{
    public partial class ViewOrder : Form
    {
        private Form1 Mainform = null;
        private readonly ViewOrderData orderData;

        public ViewOrder(ViewOrderData OrderData, Form callingForm)
        {
            InitializeComponent();
            Mainform = callingForm as Form1;
            orderData = OrderData;
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            string order_number = orderData.order_number;
            string supplierID = orderData.supplierID;
            string order_date = orderData.order_date.ToString("yyyy/MM/dd");
            string invoice_number = orderData.invoice_number;
            string invoice_date = "";
            if (orderData.invoice_date.ToString() != "")
            {
                invoice_date = String.Format("{0:yyyy/MM/dd}", orderData.invoice_date);
            }

            string supplierQuery = "SELECT * FROM tblSupplier WHERE supplierID = '" + supplierID + "'";
            string supplierData = "";

            string itemsQuery = "SELECT quantity Quantity, description Descirption, FORMAT(price, 'C', 'en-za') Price, " +
                "FORMAT(price *quantity, 'C', 'en-za') \"Total Excl\", FORMAT((price * quantity) * 1.15, 'C', 'en-za') " +
                "\"Total Incl\" FROM tblOrder_Items WHERE order_number = @order_number";

            string orderTotals = "SELECT FORMAT(SUM(price * quantity), 'C', 'en-za') \"Total Excl\", " +
                "FORMAT(SUM(price*quantity) * 0.15, 'C', 'en-za') \"15 % VAT\", FORMAT(SUM(price*quantity) * 1.15, 'C', 'en-za')" +
                " \"Total Incl\" FROM tblOrder_Items WHERE order_number = @order_number";

#pragma warning disable CS0219 // Variable is assigned but its value is never used
            bool calcVat = false;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            using(SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(supplierQuery, con))
                {
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            
                            if(sdr["company"].ToString() != "")
                            {
                                supplierData += sdr["company"].ToString() + "\n";
                            }
                            if(sdr["rep_name"].ToString() != "")
                            {
                                supplierData += sdr["rep_name"].ToString() + "\n";
                            }
                            if(sdr["email"].ToString() != "")
                            {
                                supplierData += sdr["email"].ToString() + "\n";
                            }
                            if(sdr["telephone"].ToString() != "")
                            {
                                supplierData += sdr["telephone"].ToString() + "\n";
                            }
                            if(sdr["cellphone"].ToString() != "")
                            {
                                supplierData += sdr["cellphone"].ToString() + "\n";
                            }
                            if(sdr["registration"].ToString() != "")
                            {
                                supplierData += sdr["registration"].ToString() + "\n";
                            }
                            if(sdr["address"].ToString() != "")
                            {
                                supplierData += sdr["address"].ToString() + "\n";
                            }
                            if(sdr["postal_code"].ToString() != "")
                            {
                                supplierData += sdr["postal_code"].ToString() + "\n";
                            }
                            if (char.Parse(sdr["registered"].ToString()) == 'Y')
                            {
                                calcVat = true;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                DataSet ds = new DataSet();
                using (SqlCommand cmd = new SqlCommand(itemsQuery, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = order_number;

                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(ds);
                            ItemsDGV.ReadOnly = true;
                            ItemsDGV.DataSource = ds.Tables[0];
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (SqlCommand cmd = new SqlCommand(orderTotals, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = order_number;

                    try
                    {
                        using(SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            LblTotalEx.Text = sdr["Total Excl"].ToString();
                            LblVat.Text = sdr["15 % VAT"].ToString();
                            LblTotal.Text = sdr["Total Incl"].ToString();
                        }
                    }
                    catch(SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }

            LblOrderNumber.Text = order_number;
            LblOrderDate.Text = order_date;
            LblInvoiceNumber.Text = invoice_number;
            LblInvoiceDate.Text = invoice_date;
            TxtSupplierDetails.Text = supplierData;
        }
    }
}
