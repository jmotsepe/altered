using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Altered
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Login frm = new Login();
            //frm.ShowDialog();

            FillSupplierGrid();
            FillOrdersGrid();
            FillCustomerGrid();
            FillProductGrid();
            FillInvoiceGrid();
            FillCharts();
            FillQuotesGrid();
        }

        public void FillSupplierGrid()
        {
            string query = "SELECT supplierID \"Supplier ID\", company Company, rep_name Rep, email Email, telephone Telephone, cellphone Cellphone, ";
            query += "registration Registration, registered VAT, address Address, postal_code Code FROM tblSupplier";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adaptor = new SqlDataAdapter(cmd))
                            {
                                adaptor.Fill(ds);
                                SupplierDGV.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }
        }

        public void FillCustomerGrid()
        {
            string query = "SELECT customerID \"Customer ID\" ,[company] Company,[rep_name] \"Rep Name\",[email] Email,[telephone] Telephone,[cellphone] Cellphone,[address] Address, ";
            query += "[postal_code] \"Postal Code\",[registration] Registration,[registered] VAT FROM[altered].[dbo].[tblCustomer]";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adaptor = new SqlDataAdapter(cmd))
                            {
                                adaptor.Fill(ds);
                                CustomerDGV.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }
        }

        public void FillProductGrid()
        {
            string query = "SELECT productID \"ID\", description Description, code Code, FORMAT(price, 'C', 'en-za') Price, imgLocation Image FROM tblProducts";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adaptor = new SqlDataAdapter(cmd))
                            {
                                adaptor.Fill(ds);
                                ProductDGV.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }
        }

        public void FillGrid(string query, DataGridView dataGrid)
        {
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adaptor = new SqlDataAdapter(cmd))
                            {
                                adaptor.Fill(ds);
                                dataGrid.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }
        }

        public void FillOrdersGrid()
        {
            //string query = "SELECT order_number \"Order Number\", supplierID \"Supplier ID\", order_date \"Order Date\", invoice_number \"Invoice Number\", invoice_date \"Invoice Date\" FROM tblOrders";
            string query = "SELECT tblOrders.supplierID \"Supplier ID\", company Company, order_number \"Order Number\", order_date \"Order Date\", invoice_number \"Invoice Number\", invoice_date \"Invoice Date\" FROM tblOrders JOIN tblSupplier ON tblOrders.supplierID = tblSupplier.supplierID ORDER BY order_number ASC";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(ds);
                                OrdersDGV.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }
        }

        public void FillQuotesGrid()
        {
            string query = "SELECT quote_number 'Quote Number', customerID 'Customer ID', quote_date 'Date', FORMAT(quote_total, 'C', 'en-za') \"Quote Total\" FROM tblQuotations";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(ds);
                                QuotesDGV.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }
        }

        public void FillInvoiceGrid()
        {
            string query = "SELECT invoice_number \"Invoice Number\", customerID \"Customer ID\", invoice_date \"Invoice Date\", paid Paid, invoice_paid_date " +
                "\"Payment Date\", FORMAT(invoice_total, 'C', 'en-za') \"Invoice Total\" FROM tblInvoices";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(ds);
                                InvoiceDGV.DataSource = ds.Tables[0];
                            }
                            con.Close();
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            InvoiceDGV.Rows[1].Selected = true;
        }

        private void FillCharts()                                                                                                                                                         
        {
            string year = DateTime.Today.ToString("yyyy");
            string query = "SELECT DATENAME(month, DATEADD(MONTH, MONTH(invoice_paid_date), -1)) Month, SUM(price * quantity) Sales FROM tblInvoices t1 JOIN " +
                "tblInvoice_Items t2 ON t1.invoice_number = t2.invoice_number WHERE t1.paid = 'Y' AND year(invoice_paid_date) = '" + year + "' GROUP BY MONTH(invoice_paid_date) ORDER BY MONTH(invoice_paid_date)";

            string query2 = "SELECT DATENAME(month, DATEADD(MONTH, MONTH(invoice_date), -1)) Month, SUM(price * quantity) Purchases FROM tblOrders t1 JOIN tblOrder_Items t2 ON t1.order_number = t2.order_number " +
                "WHERE year(invoice_date) = '" + year + "' GROUP BY MONTH(invoice_date) ORDER BY MONTH(invoice_date)";

            string query3 = "SELECT year(invoice_paid_date) Year, SUM(invoice_total) Sales FROM tblInvoices WHERE year(invoice_paid_date) IS NOT NULL " +
                "GROUP BY year(invoice_paid_date) ORDER BY year(invoice_paid_date)";

            string query4 = "SELECT year(invoice_date) Year, SUM(price * quantity) Expenses FROM tblOrders t1 JOIN tblOrder_Items t2 ON t1.order_number = t2.order_number " +
                "WHERE invoice_date IS NOT NULL GROUP BY year(invoice_date) ORDER BY year(invoice_date)";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                CRTSalesVsExpenses.Series["Sales"].Points.AddXY(sdr["Month"].ToString(), double.Parse(sdr["Sales"].ToString()));
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (SqlCommand cmd = new SqlCommand(query2, con))
                {
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                CRTSalesVsExpenses.Series["Purchases"].Points.AddY(double.Parse(sdr["Purchases"].ToString()));
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (SqlCommand cmd = new SqlCommand(query3, con))
                {
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                CRTYearlySales.Series["Sales"].Points.AddXY(int.Parse(sdr["Year"].ToString()), double.Parse(sdr["Sales"].ToString()));
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (SqlCommand cmd = new SqlCommand(query4, con))
                {
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                CRTYearlySales.Series["Expenses"].Points.AddXY(int.Parse(sdr["Year"].ToString()), double.Parse(sdr["Expenses"].ToString()));
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
        }

        private void BtnEditSupplier_Click(object sender, EventArgs e)
        {
            UpdateData updateData = new UpdateData
            {
                ID = SupplierDGV.CurrentRow.Cells[0].Value.ToString(),
                table = "tblSupplier",
                column = "supplierID",
                header = "Update Supplier"
            };
            EditForm editSupplier = new EditForm(updateData, this);
            editSupplier.ShowDialog();
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            if (TxtSupCompany.Text == "" && TxtSupRepName.Text == "")
            {
                _ = MessageBox.Show("Supplier and Rep name are both empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ = TxtSupCompany.Focus();
            }
            else if (TxtSupEmail.Text == "" && TxtSupTelephone.Text == "" && TxtSupCellphone.Text == "")
            {
                _ = MessageBox.Show("Supplier must have at least one contact method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtSupEmail.Focus();
            }
            else if (TxtSupEmail.Text != "" && RegexUtilities.IsValidEmail(TxtSupEmail.Text) == false)
            {
                _ = MessageBox.Show(TxtSupEmail.Text + " is not a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtSupEmail.Focus();
                TxtSupEmail.SelectAll();
            }
            else if (TxtSupAddress.Text == "")
            {
                _ = MessageBox.Show("Address cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtSupAddress.Focus();
            }
            else if ((TxtSupPostCode.Text == "" && TxtSupAddress.Text != "") || ValidateIntegers(TxtSupPostCode.Text) == false)
            {
                _ = MessageBox.Show("Invalid postal code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtSupPostCode.Focus();
            }
            else
            {
                char vat_registered = 'N';
                if (SupVatYes.Checked == true)
                {
                    vat_registered = 'Y';
                }

                string supplierNumber = "TMTS" + NextNumber.NextSequence("tblSupplier", "supplierID");
                _ = new Supplier(supplierNumber, TxtSupCompany.Text, TxtSupRepName.Text, TxtSupEmail.Text, TxtSupTelephone.Text, TxtSupCellphone.Text, TxtSupRegistration.Text, vat_registered, TxtSupAddress.Text, TxtSupPostCode.Text, false);
                string query = "SELECT supplierID \"Supplier ID\", company Company, rep_name Rep, email Email, telephone Telephone, cellphone Cellphone, ";
                query += "registration Registration, registered VAT, address Address, postal_code Code FROM tblSupplier";

                FillGrid(query, SupplierDGV);

                TxtSupCompany.Text = "";
                TxtSupRepName.Text = "";
                TxtSupEmail.Text = "";
                TxtSupTelephone.Text = "";
                TxtSupCellphone.Text = "";
                TxtSupRegistration.Text = "";
                SupVatNo.Checked = true;
                TxtSupAddress.Text = "";
                TxtSupPostCode.Text = "";
            }
        }

        private void BtnCancelSupplier_Click(object sender, EventArgs e)
        {
            TxtSupCompany.Text = "";
            TxtSupRepName.Text = "";
            TxtSupEmail.Text = "";
            TxtSupTelephone.Text = "";
            TxtSupCellphone.Text = "";
            TxtSupRegistration.Text = "";
            SupVatNo.Checked = true;
            TxtSupAddress.Text = "";
            TxtSupPostCode.Text = "";
        }

        private bool ValidateIntegers(string validationText)
        {
            try
            {
                _ = int.Parse(validationText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateDoubles(string validationText)
        {
            try
            {
                _ = double.Parse(validationText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder(this);
            newOrder.ShowDialog();
            FillCharts();
        }

        private void BtnNewQuote_Click(object sender, EventArgs e)
        {
            NewQuote newQuote = new NewQuote(this);
            newQuote.ShowDialog();
            FillCharts();

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (TxtCusCompany.Text == "" && TxtCusRepName.Text == "")
            {
                _ = MessageBox.Show("Company and Rep name are both empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ = TxtCusCompany.Focus();
            }
            else if (TxtCusEmail.Text == "" && TxtCusTelephone.Text == "" && TxtCusCellphone.Text == "")
            {
                _ = MessageBox.Show("Customer must have at least one contact method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtCusEmail.Focus();
            }
            else if (TxtCusEmail.Text != "" && RegexUtilities.IsValidEmail(TxtCusEmail.Text) == false)
            {
                _ = MessageBox.Show(TxtCusEmail.Text + " is not a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtCusEmail.Focus();
                TxtCusEmail.SelectAll();
            }
            else if (TxtCusAddress.Text != "" && TxtCusPosCode.Text == "")
            {
                _ = MessageBox.Show("Missing postal code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtCusPosCode.Focus();
            }
            else if (TxtCusPosCode.Text != "" && ValidateIntegers(TxtCusPosCode.Text) == false)
            {
                _ = MessageBox.Show("Invalid postal code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtCusPosCode.Focus();
            }
            else
            {
                char vat_registered = 'N';
                if (CusVatYes.Checked == true)
                {
                    vat_registered = 'Y';
                }

                string customerNumber = "TMTC" + NextNumber.NextSequence("tblCustomer", "customerID");
                _ = new Customer(customerNumber, TxtCusCompany.Text, TxtCusRepName.Text, TxtCusEmail.Text, TxtCusTelephone.Text, TxtCusCellphone.Text, TxtCusRegistration.Text, vat_registered, TxtCusAddress.Text, TxtCusPosCode.Text, false);
                string query = "SELECT customerID \"Customer ID\" ,[company] Company,[rep_name] \"Rep Name\",[email] Email,[telephone] Telephone,[cellphone] Cellphone,[address] Address, ";
                query += "[postal_code] \"Postal Code\",[registration] Registration,[Registered] VAT FROM[altered].[dbo].[tblCustomer]";

                FillGrid(query, CustomerDGV);

                TxtCusCompany.Text = "";
                TxtCusRepName.Text = "";
                TxtCusEmail.Text = "";
                TxtCusTelephone.Text = "";
                TxtCusCellphone.Text = "";
                TxtCusRegistration.Text = "";
                CusVatNo.Checked = true;
                TxtCusAddress.Text = "";
                TxtCusPosCode.Text = "";
            }
        }

        private void BtnCancelCustomer_Click(object sender, EventArgs e)
        {
            TxtCusCompany.Text = "";
            TxtCusRepName.Text = "";
            TxtCusEmail.Text = "";
            TxtCusTelephone.Text = "";
            TxtCusCellphone.Text = "";
            TxtCusRegistration.Text = "";
            CusVatNo.Checked = true;
            TxtCusAddress.Text = "";
            TxtCusPosCode.Text = "";
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {
            UpdateData updateData = new UpdateData
            {
                ID = CustomerDGV.CurrentRow.Cells[0].Value.ToString(),
                table = "tblCustomer",
                column = "customerID",
                header = "Update Customer"
            };
            EditForm editCustomer = new EditForm(updateData, this);
            editCustomer.ShowDialog();
        }

        private void BtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            string table = "tblSupplier";
            string column = "supplierID";
            string ID = SupplierDGV.CurrentRow.Cells[0].Value.ToString();
            DeleteCommand(table, column, ID);
        }

        private void DeleteCommand(string table, string column, string ID)
        {
            string query = "DELETE FROM " + table + " WHERE " + column + " = '" + ID + "'";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        if (table == "tblSupplier")
                        {
                            _ = MessageBox.Show("Supplier deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (table == "tblCustomer")
                        {
                            _ = MessageBox.Show("Customer deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (table == "tblOrders")
                        {
                            _ = MessageBox.Show("Order deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (table == "tblInvoices")
                        {
                            _ = MessageBox.Show("Invoice deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException)
                    {
                        _ = MessageBox.Show("The request cannot be fulfilled as it would violate integrity constraints", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string table = "tblCustomer";
            string column = "customerID";
            string ID = CustomerDGV.CurrentRow.Cells[0].Value.ToString();
            DeleteCommand(table, column, ID);
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            string ID = OrdersDGV.CurrentRow.Cells[0].Value.ToString();
            string table = "tblOrders";
            string column = "order_number";

            DeleteCommand(table, column, ID);
        }

        private void BtnNewInvoice_Click(object sender, EventArgs e)
        {
            NewInvoice newInvoice = new NewInvoice(this);
            _ = newInvoice.ShowDialog();
            FillCharts();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            if (TxtProductDesc.Text == "" || TxtProductPrice.Text == "" || TxtPictureLocation.Text == "")
            {
                _ = MessageBox.Show("Product data missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValidateDoubles(TxtProductPrice.Text) == false)
            {
                _ = MessageBox.Show("Price has invalid characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtProductPrice.Focus();
            }
            else
            {
                if (TxtProductID.Text == "")
                {
                    _ = new Product(TxtProductDesc.Text, double.Parse(TxtProductPrice.Text), TxtPictureLocation.Text, false);
                }
                else
                {
                    _ = new Product(int.Parse(TxtProductID.Text), TxtProductDesc.Text, double.Parse(TxtProductPrice.Text), TxtPictureLocation.Text, true);
                }
            }

            FillProductGrid();
            if (TxtProductID.Text != "")
            {
                ProductDGV.Rows[int.Parse(TxtProductID.Text) - 1].Selected = true;
            }
            TxtProductDesc.Text = "";
            TxtProductPrice.Text = "";
            TxtPictureLocation.Text = "";
            TxtProductID.Text = "";
            BtnAddProduct.Text = "Add";
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            TxtProductID.Text = ProductDGV.CurrentRow.Cells[0].Value.ToString();
            TxtProductDesc.Text = ProductDGV.CurrentRow.Cells[1].Value.ToString();
            TxtProductPrice.Text = ProductDGV.CurrentRow.Cells[3].Value.ToString().Substring(1);
            TxtPictureLocation.Text = ProductDGV.CurrentRow.Cells[4].Value.ToString();
            BtnAddProduct.Text = "Update";
            BtnAddProduct.Enabled = true;
        }

        private void BtnCancelProduct_Click(object sender, EventArgs e)
        {
            TxtProductDesc.Text = "";
            TxtProductPrice.Text = "";
            TxtPictureLocation.Text = "";
            BtnAddProduct.Text = "Add";
        }

        private void BtnUpdateInvoice_Click(object sender, EventArgs e)
        {
            int rowIndex = InvoiceDGV.CurrentRow.Index;
            string invoice_number = LblInvoiceNumber.Text;
            DateTime paymentDate = DateTime.Parse(DateInvoicePaidDate.Value.ToString("yyyy/MM/dd"));
            double paymentAmount = 0.00;
            double invoiceTotal = double.Parse(InvoiceDGV.CurrentRow.Cells[5].Value.ToString().Substring(1));

            if (ValidateDoubles(TxtPaymentAmount.Text) == false)
            {
                MessageBox.Show("Enter a valid payment amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPaymentAmount.Focus();
                TxtPaymentAmount.SelectAll();
            }
            else
            {
                paymentAmount = double.Parse(TxtPaymentAmount.Text);
            }

            if (paymentAmount <= 0)
            {
                MessageBox.Show("Payment amount may not be less than or equal to R0.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPaymentAmount.Focus();
                TxtPaymentAmount.SelectAll();
            }

            _ = new Invoice(invoice_number, paymentDate, invoiceTotal, paymentAmount);

            FillInvoiceGrid();
            FillCharts();
            DisplayInvoicePayments();
            TxtPaymentAmount.Clear();
            InvoiceDGV.Rows[rowIndex].Selected = true;
            InvoiceDGV.CurrentCell = InvoiceDGV.Rows[rowIndex].Cells[0];
        }

        private void BtnDeleteInvoice_Click(object sender, EventArgs e)
        {
            string ID = InvoiceDGV.CurrentRow.Cells[0].Value.ToString();
            string table = "tblInvoices";
            string column = "invoice_number";

            DeleteCommand(table, column, ID);
        }

        private void BnDeleteQuote_Click(object sender, EventArgs e)
        {
            string ID = QuotesDGV.CurrentRow.Cells[0].Value.ToString();
            string table = "tblQuotations";
            string column = "quote_number";

            DeleteCommand(table, column, ID);
        }

        private void BtnYearlySales_Click(object sender, EventArgs e)
        {
            ReportsChart.Series["Series1"].Points.Clear();
            if (TxtReportYear.Text == "")
            {
                _ = MessageBox.Show("Enter a year in the \"Report Year\" Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string year = TxtReportYear.Text;
                string query = "SELECT DATENAME(month, DATEADD(MONTH, MONTH(invoice_date), -1)) Month, FORMAT(SUM(price * quantity), 'C', 'en-za') Sales FROM tblInvoices t1 JOIN " +
                    "tblInvoice_Items t2 ON t1.invoice_number = t2.invoice_number WHERE t1.paid = 'Y' AND year(invoice_date) = '" + year + "' GROUP BY MONTH(invoice_date) ORDER BY MONTH(invoice_date)";

                using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    ReportsChart.Series["Series1"].Points.AddXY(sdr["Month"].ToString(), double.Parse(sdr["Sales"].ToString().Substring(1)));
                                    ReportsChart.Series["Series1"].LegendText = year + " Sales";
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    using (DataSet ds = new DataSet())
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            try
                            {
                                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                {
                                    adapter.Fill(ds);
                                    ReportsDGV.DataSource = ds.Tables[0];
                                }
                            }
                            catch (SqlException ex)
                            {
                                _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    con.Close();
                }
            }
            ReportsChart.Visible = true;
            ReportsDGV.Visible = true;
        }

        private void BtnMonthlyExpenses_Click(object sender, EventArgs e)
        {
            ReportsChart.Series["Series1"].Points.Clear();
            if (TxtReportYear.Text == "")
            {
                _ = MessageBox.Show("Enter a year in the \"Report Year\" Textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string year = TxtReportYear.Text;
                string query = "SELECT DATENAME(month, DATEADD(MONTH, MONTH(invoice_date), -1)) Month, FORMAT(SUM(price * quantity), 'C', 'en-za') Purchases FROM tblOrders t1 JOIN tblOrder_Items t2 ON t1.order_number = t2.order_number " +
                "WHERE year(invoice_date) = '" + year + "' GROUP BY MONTH(invoice_date) ORDER BY MONTH(invoice_date)";

                using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                while (sdr.Read())
                                {
                                    ReportsChart.Series["Series1"].Points.AddXY(sdr["Month"].ToString(), double.Parse(sdr["Purchases"].ToString().Substring(1)));
                                    ReportsChart.Series["Series1"].LegendText = year + " Purchases";
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    using (DataSet ds = new DataSet())
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            try
                            {

                                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                {
                                    adapter.Fill(ds);
                                    ReportsDGV.DataSource = ds.Tables[0];
                                }
                            }
                            catch (SqlException ex)
                            {
                                _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    con.Close();
                }
            }
            ReportsChart.Visible = true;
            ReportsDGV.Visible = true;
        }

        private void BtnYearSales_Click(object sender, EventArgs e)
        {
            string query = "SELECT year(invoice_paid_date) Year, FORMAT(SUM(invoice_total), 'C', 'en-za') Sales FROM tblInvoices WHERE year(invoice_paid_date) IS NOT NULL " +
                "GROUP BY year(invoice_paid_date) ORDER BY year(invoice_paid_date)";
            
            ReportsChart.Series["Series1"].Points.Clear();

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                ReportsChart.Series["Series1"].Points.AddXY(sdr["Year"].ToString(), double.Parse(sdr["Sales"].ToString().Substring(1)));
                                ReportsChart.Series["Series1"].LegendText = "Yearly Sales";
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        try
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(ds);
                                ReportsDGV.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                con.Close();
            }
            ReportsChart.Visible = true;
            ReportsDGV.Visible = true;
        }

        private void BtnClearReports_Click(object sender, EventArgs e)
        {
            ReportsChart.Visible = false;
            ReportsDGV.Visible = false;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            string storedProc = "sp_backupAltered";
            DateTime date = DateTime.Now.Date;
            string backupFile = "C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\altered_" + date.ToString("yyyyMMdd") + ".bak";
            if (File.Exists(backupFile))
            {
                File.Delete(backupFile);
            }

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(storedProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        con.Open();
                        _ = cmd.ExecuteNonQuery();
                        _ = MessageBox.Show("Database backup Complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void BtnConvertInvoice_Click(object sender, EventArgs e)
        {
            InvoiceEmailPrint("Print");
        }

        private void BtnConvertQuote_Click(object sender, EventArgs e)
        {
            QuoteEmailPrint("Print");
        }

        private void BtnEmailInvoice_Click(object sender, EventArgs e)
        {
            InvoiceEmailPrint("Email");
        }

        private void BtnEmailQuote_Click(object sender, EventArgs e)
        {
            QuoteEmailPrint("Email");
        }

        private void InvoiceEmailPrint(string emailPrint)
        {
            string invoice_number = InvoiceDGV.CurrentRow.Cells[0].Value.ToString();
            string customerID = InvoiceDGV.CurrentRow.Cells[1].Value.ToString();
            string invoice_date = InvoiceDGV.CurrentRow.Cells[2].Value.ToString();

            string query = "SELECT * FROM tblCustomer WHERE customerID = '" + customerID + "'";
            string queryItems = "SELECT quantity Quantity, t2.description Description, t1.price Price, t1.price * quantity Total";
            queryItems += " FROM tblInvoice_Items t1 JOIN tblProducts t2 ON t2.productID = t1.productID WHERE invoice_number = '" + invoice_number + "'";

            _ = new ConvertDocument(invoice_number, customerID, invoice_date, query, queryItems, emailPrint);
        }

        private void QuoteEmailPrint(string emailPrint)
        {
            string quote_number = QuotesDGV.CurrentRow.Cells[0].Value.ToString();
            string customerID = QuotesDGV.CurrentRow.Cells[1].Value.ToString();
            string quote_date = QuotesDGV.CurrentRow.Cells[2].Value.ToString();

            string query = "SELECT * FROM tblCustomer WHERE customerID = '" + customerID + "'";
            string queryItems = "SELECT quantity Quantity, t2.description Description, t1.price Price, t1.price * quantity Total FROM tblQuoteItems t1 JOIN tblProducts t2 " +
                "ON t2.productID = t1.productID WHERE quote_number = '" + quote_number + "'";

            _ = new ConvertQuote(quote_number, customerID, quote_date, query, queryItems, emailPrint);

        }

        private void InvoiceDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayInvoiceDetails();
            DisplayInvoiceItems();
            DisplayInvoicePayments();
        }

        private void DisplayInvoiceDetails()
        {
            LblInvoiceNumber.Text = InvoiceDGV.CurrentRow.Cells[0].Value.ToString();

            if (InvoiceDGV.CurrentRow.Cells[3].Value.ToString() == "Y")
            {
                BtnUpdateInvoice.Enabled = false;
                DateInvoicePaidDate.Enabled = false;
            }
            else if (InvoiceDGV.CurrentRow.Cells[3].Value.ToString() == "N")
            {
                BtnUpdateInvoice.Enabled = true;
                DateInvoicePaidDate.Enabled = true;
            }

            if (InvoiceDGV.CurrentRow.Cells[4].Value.ToString() != "")
            {
                DateInvoicePaidDate.Value = DateTime.Parse(InvoiceDGV.CurrentRow.Cells[4].Value.ToString());
            }
            else
            {
                DateInvoicePaidDate.Value = DateTime.Today;
            }
        }

        private void DisplayInvoiceItems()
        {
            string query = "SELECT quantity Quantity, t2.description Description, FORMAT(t1.price, 'C', 'en-za') Price, FORMAT(t1.price * quantity, 'C', 'en-za') Total";
            query += " FROM tblInvoice_Items t1 JOIN tblProducts t2 ON t2.productID = t1.productID WHERE invoice_number = @order_number";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = InvoiceDGV.CurrentRow.Cells[0].Value.ToString();

                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(ds);
                                ViewItemsDGV.DataSource = ds.Tables[0];
                            }
                            con.Close();
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DisplayInvoicePayments()
        {
            string query = "SELECT invoice_number 'Invoice', payment_date 'Payment Date', FORMAT(invoice_total, 'C', 'en-za') 'Invoice Total', FORMAT(payment_amount, 'C', 'en-za') 'Amount Paid' FROM tblPayments WHERE invoice_number = @invoice_number";
            string query2 = "SELECT invoice_paid_date, FORMAT(tblPayments.invoice_total - SUM(payment_amount), 'C', 'en-za') Outstanding FROM tblPayments JOIN tblInvoices ON tblPayments.invoice_number = tblInvoices.invoice_number " + "" +
                "WHERE tblPayments.invoice_number = @invoice_number GROUP BY invoice_paid_date, tblPayments.invoice_total";
            string invoice_number = InvoiceDGV.CurrentRow.Cells[0].Value.ToString();

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@invoice_number", SqlDbType.VarChar).Value = invoice_number;

                        try
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(ds);
                                PaymentsDGV.DataSource = ds.Tables[0];
                            }
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    using (SqlCommand cmd = new SqlCommand(query2, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@invoice_number", SqlDbType.VarChar).Value = invoice_number;

                        try
                        {
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    LblOutstanding.Text = sdr["Outstanding"].ToString();
                                }
                                else
                                {
                                    LblOutstanding.Text = InvoiceDGV.CurrentRow.Cells[5].Value.ToString();
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
            }
        }

        private void OrdersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayOrderDetails();
            DisplayOrderItems();
        }

        private void DisplayOrderDetails()
        {
            LblOrderNumber.Text = OrdersDGV.CurrentRow.Cells[2].Value.ToString();

            if (OrdersDGV.CurrentRow.Cells[4].Value.ToString() != "")
            {
                BtnUpdateOrder.Enabled = false;
                DtInvoiceDate.Enabled = false;
                TxtInvoiceNumber.ReadOnly = true;
                TxtInvoiceNumber.Text = OrdersDGV.CurrentRow.Cells[4].Value.ToString();
                DtInvoiceDate.Value = DateTime.Parse(OrdersDGV.CurrentRow.Cells[5].Value.ToString());
            }
            else if (OrdersDGV.CurrentRow.Cells[4].Value.ToString() == "")
            {
                BtnUpdateOrder.Enabled = true;
                DtInvoiceDate.Enabled = true;
                TxtInvoiceNumber.ReadOnly = false;
                TxtInvoiceNumber.Text = "";
                DtInvoiceDate.Value = DateTime.Today;
            }
        }

        private void DisplayOrderItems()
        {
            ViewOrderItemsDGV.DataSource = null;
            string supplierID = OrdersDGV.CurrentRow.Cells[0].Value.ToString();
            string query = "SELECT registered FROM tblSupplier WHERE supplierID = @supplierID";
            string vatQuery = "SELECT quantity Quantity, description Description, FORMAT(price, 'C', 'en-za') Price, FORMAT((price * quantity) *0.15, 'C', 'en-za') 'VAT @ 15%', FORMAT((price * quantity) * 1.15, 'C', 'en-za') Total";
            vatQuery += " FROM tblOrder_items WHERE order_number = @order_number";
            string noVatQuery = "SELECT quantity Quantity, description Description, FORMAT(price, 'C', 'en-za') Price, FORMAT(price * quantity, 'C', 'en-za') Total FROM tblOrder_items WHERE order_number = @order_number";

            char registered = 'N';

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@supplierID", SqlDbType.VarChar).Value = supplierID;

                    try
                    {
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            registered = char.Parse(sdr["registered"].ToString());
                        }
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (registered == 'Y')
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlCommand cmd = new SqlCommand(vatQuery, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = OrdersDGV.CurrentRow.Cells[2].Value.ToString();

                            try
                            {
                                con.Open();
                                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                {
                                    adapter.Fill(ds);
                                    ViewOrderItemsDGV.DataSource = ds.Tables[0];
                                }
                                con.Close();
                            }
                            catch (SqlException ex)
                            {
                                _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else if (registered == 'N')
            {
                using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlCommand cmd = new SqlCommand(noVatQuery, con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@order_number", SqlDbType.VarChar).Value = OrdersDGV.CurrentRow.Cells[2].Value.ToString();

                            try
                            {
                                con.Open();
                                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                {
                                    adapter.Fill(ds);
                                    ViewOrderItemsDGV.DataSource = ds.Tables[0];
                                }
                                con.Close();
                            }
                            catch (SqlException ex)
                            {
                                _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void QuotesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayQuoteDetails();
            DisplayQuoteItems();
        }

        private void DisplayQuoteDetails()
        {
            string query = "SELECT rep_name, telephone, cellphone FROM tblCustomer WHERE customerID = @customerID";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@customerID", SqlDbType.VarChar).Value = QuotesDGV.CurrentRow.Cells[1].Value.ToString();

                    try
                    {
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            LblCustomerName.Text = sdr["rep_name"].ToString();

                            if (sdr["telephone"].ToString() != "")
                            {
                                LblCustomerContact.Text = sdr["telephone"].ToString();
                            }
                            else
                            {
                                LblCustomerContact.Text = sdr["cellphone"].ToString();
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DisplayQuoteItems()
        {
            string query = "SELECT quantity Quantity, t2.description Description, FORMAT(t1.price, 'C', 'en-za') Price, FORMAT(t1.price * quantity, 'C', 'en-za') Total ";
            query += "FROM tblQuoteItems t1 JOIN tblProducts t2 ON t2.productID = t1.productID ";
            query += "WHERE quote_number = @quote_number";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@quote_number", SqlDbType.VarChar).Value = QuotesDGV.CurrentRow.Cells[0].Value.ToString();

                        try
                        {
                            con.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(ds);
                                ViewQuoteItemsDGV.DataSource = ds.Tables[0];
                            }
                            con.Close();
                        }
                        catch (SqlException ex)
                        {
                            _ = MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnUpdateOrder_Click(object sender, EventArgs e)
        {
            string order_number = LblOrderNumber.Text;
            string invoice_number = TxtInvoiceNumber.Text;
            DateTime invoice_date = DateTime.Parse(DtInvoiceDate.Value.ToString("yyyy/MM/dd"));
            int rowIndex = OrdersDGV.CurrentRow.Index;

            _ = new Order(order_number, invoice_number, invoice_date);

            FillCharts();
            TxtInvoiceNumber.Clear();
            OrdersDGV.Rows[rowIndex].Selected = true;
            OrdersDGV.CurrentCell = OrdersDGV.Rows[rowIndex].Cells[0];
            FillOrdersGrid(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}