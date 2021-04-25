using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Altered
{
    public partial class AddItem : Form
    {
        public Button btnAdd { get; set; }
        public DataGridView itemDGV { get; set; }
        public Button btnEdit { get; set; }
        public Button btnDelete { get; set; }
        public Button btnConfirm { get; set; }
        public Label lblTotalExcl { get; set; }
        public Label lblVat { get; set; }
        public Label lblTotalIncl { get; set; }
        public RadioButton vatYes { get; set; }
        public RadioButton vatNo { get; set; }
        public bool Edit { get; set; }

        private int rowIndex = 0;

        public AddItem()
        {
            InitializeComponent();
        }

        //private Form1 Mainform = null;
        //private readonly UpdateInvoiceItem invoiceData;

        //public AddItem(UpdateInvoiceItem InvoiceData, Form callingForm)
        //{
        //    InitializeComponent();
        //    Mainform = callingForm as Form1;
        //    invoiceData = InvoiceData;
        //}

        private void AddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alteredDataSet1.tblProducts' table. You can move, or remove it, as needed.
            tblProductsTableAdapter.Fill(alteredDataSet1.tblProducts);
            CmbItem.SelectedIndex = 1;
            if(Edit == true)
            {
                CmbItem.SelectedValue = itemDGV.CurrentRow.Cells[0].Value.ToString();
                NumQuantity.Value = int.Parse(itemDGV.CurrentRow.Cells[1].Value.ToString());
                TxtDescription.Text = itemDGV.CurrentRow.Cells[2].Value.ToString();
                TxtPrice.Text = itemDGV.CurrentRow.Cells[3].Value.ToString();
                rowIndex = itemDGV.CurrentRow.Index;
                Text = "Edit Update";
                BtnAdd.Text = "Update";
            }
        }

        private void CmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productID = CmbItem.SelectedValue.ToString();
            string query = "SELECT description, FORMAT(price, 'C', 'en-za') Price FROM tblProducts WHERE productID = " + productID;

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            TxtDescription.Text = sdr["description"].ToString();
                            TxtPrice.Text = sdr["Price"].ToString();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (NumQuantity.Value == 0)
            {
                _ = MessageBox.Show("Quantity must be more than zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NumQuantity.Focus();
            }
            else
            {
                int productID = int.Parse(CmbItem.SelectedValue.ToString());
                string itemDesc = TxtDescription.Text;
                string price = TxtPrice.Text;
                int quantity = int.Parse(NumQuantity.Value.ToString());
                double total = quantity * double.Parse(price.Substring(1));


                if (Edit == true)
                {
                    itemDGV.Rows.RemoveAt(rowIndex);
                    itemDGV.Rows.Add(productID, quantity, itemDesc, price, total.ToString("C2"));
                    itemDGV.ClearSelection();
                }
                else
                {
                    itemDGV.Rows.Add(productID, quantity, itemDesc, price, total.ToString("C2"));
                    itemDGV.ClearSelection();
                }
                InvoiceTotals();
                if (vatNo.Enabled == true) vatNo.Enabled = false;
                if (vatYes.Enabled == true) vatYes.Enabled = false;
                if (btnEdit.Enabled == false) btnEdit.Enabled = true;
                if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                if (btnConfirm.Enabled == false) btnConfirm.Enabled = true;
                Close();
            }
        }

        private void InvoiceTotals()
        {
            double totalExcl = 0;
            double totalVat = 0;
            double totalIncl = 0;

            foreach (DataGridViewRow row in itemDGV.Rows)
            {
                totalExcl += double.Parse(row.Cells[4].Value.ToString().Substring(1));
            }

            if (vatYes.Checked == true)
            {
                totalVat = totalExcl * 0.15;
            }
            else
            {
                totalVat = 0;
            }

            totalIncl = totalExcl + totalVat;


            lblTotalExcl.Text = totalExcl.ToString("C2");
            lblVat.Text = totalVat.ToString("C2");
            lblTotalIncl.Text = totalIncl.ToString("C2");
        }
    }
}
