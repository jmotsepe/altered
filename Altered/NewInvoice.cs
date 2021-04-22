using System;
using System.Windows.Forms;

namespace Altered
{
    public partial class NewInvoice : Form
    {
        private Form1 Mainform = null;
        public NewInvoice(Form callingForm)
        {
            InitializeComponent();
            Mainform = callingForm as Form1;
        }

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alteredDataSet.tblCustomer' table. You can move, or remove it, as needed.
            tblCustomerTableAdapter.Fill(alteredDataSet.tblCustomer);


            string invoiceNumber = "TMTI" + NextNumber.NextSequence("tblInvoices", "invoice_number");
            Text = invoiceNumber;
            LblInvoiceNumber.Text = invoiceNumber;
            LblInvoiceDate.Text = DateTime.Today.ToString("yyyy/MM/dd");
            LblTotalEx.Text = "";
            LblVat.Text = "";
            LblTotal.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.btnAdd = BtnAdd;
            addItem.itemDGV = ItemDGV;
            addItem.btnConfirm = BtnConfirm;
            addItem.btnDelete = BtnDelete;
            addItem.btnEdit = BtnEdit;
            addItem.lblTotalExcl = LblTotalEx;
            addItem.lblVat = LblVat;
            addItem.lblTotalIncl = LblTotal;
            addItem.vatYes = RadVatYes;
            addItem.vatNo = RadVatNo;
            addItem.Edit = false;
            _ = addItem.ShowDialog(this);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.btnAdd = BtnAdd;
            addItem.itemDGV = ItemDGV;
            addItem.btnConfirm = BtnConfirm;
            addItem.btnDelete = BtnDelete;
            addItem.btnEdit = BtnEdit;
            addItem.lblTotalExcl = LblTotalEx;
            addItem.lblVat = LblVat;
            addItem.lblTotalIncl = LblTotal;
            addItem.vatYes = RadVatYes;
            addItem.vatNo = RadVatNo;
            addItem.Edit = true;
            _ = addItem.ShowDialog(this);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ItemDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult deleteResult = MessageBox.Show("Are you sure want to remove the selected order item", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteResult == DialogResult.Yes)
                {
                    double totalExcl = double.Parse(LblTotalEx.Text.Substring(1));
                    double orderVAT = double.Parse(LblVat.Text.Substring(1));
                    double totalIncl = double.Parse(LblTotal.Text.Substring(1));

                    double itemTotalExcl = double.Parse(ItemDGV.CurrentRow.Cells[3].Value.ToString().Substring(1));
                    double itemVAT = itemTotalExcl * 0.15;
                    double itemTotalIncl = itemTotalExcl + itemVAT;

                    if(RadVatYes.Checked == true)
                    {
                        totalExcl -= itemTotalExcl;
                        orderVAT -= itemVAT;
                        totalIncl -= itemTotalIncl;
                    }
                    else
                    {
                        totalExcl -= itemTotalExcl;
                        totalIncl -= itemTotalExcl;
                    }                    
                    

                    ItemDGV.Rows.RemoveAt(ItemDGV.CurrentRow.Index);

                    LblTotalEx.Text = totalExcl.ToString("C2");
                    LblVat.Text = orderVAT.ToString("C2");
                    LblTotal.Text = totalIncl.ToString("C2");
                    ItemDGV.Refresh();
                }
                else
                {
                    ItemDGV.SelectedRows[ItemDGV.CurrentRow.Index].Selected = true;

                }
            }

            if (ItemDGV.Rows.Count == 0)
            {
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                BtnConfirm.Enabled = false;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string invoice_number = LblInvoiceNumber.Text;
            string customerID = CmbCustomerID.SelectedValue.ToString();
            DateTime invoice_date = DateInvoiceDate.Value.Date;
            char paid = 'N';
            DateTime? invoice_paid_date = null;
            double invoice_total = double.Parse(LblTotal.Text.Substring(1));

            if (RadPaidYes.Checked == true)
            {
                paid = 'Y';
                invoice_paid_date = DateTime.Today;
            }
            _ = new Invoice(invoice_number, customerID, invoice_date, paid, invoice_paid_date, invoice_total, ItemDGV);
            Mainform.FillInvoiceGrid();
            Close();
        }
    }
}
