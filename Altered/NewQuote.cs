using System;
using System.Windows.Forms;

namespace Altered
{
    public partial class NewQuote : Form
    {
        private Form1 Mainform = null;

        public NewQuote(Form callingForm)
        {
            InitializeComponent();
            Mainform = callingForm as Form1;
        }

        private void NewQuote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alteredDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.alteredDataSet.tblCustomer);

            string quoteNumber = "TMTQ" + NextNumber.NextSequence("tblQuotations", "quote_number");
            Text = quoteNumber;
            LblQuoteNumber.Text = quoteNumber;
            LblQuoteDate.Text = DateTime.Today.ToString("yyyy/MM/dd");
            LblTotalEx.Text = "";
            LblVat.Text = "";
            LblTotal.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.btnAdd = BtnAdd;
            addItem.itemDGV = QuoteItemDGV;
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
            addItem.itemDGV = QuoteItemDGV;
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
            if(QuoteItemDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult deleteResult = MessageBox.Show("Are you sure want to remove the selected item", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(deleteResult == DialogResult.Yes)
                {
                    double totalExcl = double.Parse(LblTotalEx.Text.Substring(1));
                    double orderVAT = double.Parse(LblVat.Text.Substring(1));
                    double totalIncl = double.Parse(LblTotal.Text.Substring(1));

                    double itemTotalExcl = double.Parse(QuoteItemDGV.CurrentRow.Cells[3].Value.ToString().Substring(1));
                    double itemVAT = itemTotalExcl * 0.15;
                    double itemTotalIncl = itemTotalExcl + itemVAT;

                    if (RadVatYes.Checked == true)
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

                    QuoteItemDGV.Rows.RemoveAt(QuoteItemDGV.CurrentRow.Index);

                    LblTotalEx.Text = totalExcl.ToString("C2");
                    LblVat.Text = orderVAT.ToString("C2");
                    LblTotal.Text = totalIncl.ToString("C2");
                    QuoteItemDGV.Refresh();
                }
                else
                {
                    QuoteItemDGV.SelectedRows[QuoteItemDGV.CurrentRow.Index].Selected = true;
                }
            }

            if(QuoteItemDGV.Rows.Count == 0)
            {
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                BtnConfirm.Enabled = false;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string quote_number = LblQuoteNumber.Text;
            string customerID = CmbCustomerID.SelectedValue.ToString();
            DateTime quote_date = DateQuoteDate.Value.Date;
            double quote_total = double.Parse(LblTotal.Text.Substring(1));

            _ = new Quotation(quote_number, customerID, quote_date, quote_total, QuoteItemDGV);
            Mainform.FillQuotesGrid();
            Close();
        }
    }
}
