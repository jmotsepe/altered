using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altered
{
    public partial class NewOrder : Form
    {
        private Form1 Mainform = null;

        public NewOrder(Form callingForm)
        {
            InitializeComponent();
            Mainform = callingForm as Form1;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alteredDataSet.tblSupplier' table. You can move, or remove it, as needed.
            tblSupplierTableAdapter.Fill(alteredDataSet.tblSupplier);
            string orderNumber = "TMTO" + NextNumber.NextSequence("tblOrders", "order_number");
            Text = orderNumber;
            TxtOrderNumber.Text = orderNumber;
            TxtOrderDate.Text = DateTime.Today.ToString("yyyy/MM/dd");
            VatExcluded.Checked = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.orderDGV = ItemDGV;
            orderItem.txtOrderTotalExcl = TxtTotalExcl;
            orderItem.txtOrderVAT = TxtVat;
            orderItem.txtOrderTotalIncl = TxtOrderTotal;
            orderItem.btnEditItem = BtnEdit;
            orderItem.btnDeleteItem = BtnDelete;
            orderItem.btnConfirmOrder = BtnSubmit;
            orderItem.vatExclusive = VatExcluded;
            orderItem.vatInclusive = VatIncluded;
            _ = orderItem.ShowDialog(this);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            UpdateOrderItem OrderData = new UpdateOrderItem
            {
                lineQuantity = int.Parse(ItemDGV.CurrentRow.Cells[0].Value.ToString()),
                lineDesc = ItemDGV.CurrentRow.Cells[1].Value.ToString(),
                linePrice = double.Parse(ItemDGV.CurrentRow.Cells[2].Value.ToString()),
                lineTotalExcl = double.Parse(ItemDGV.CurrentRow.Cells[3].Value.ToString()),
                lineTotalIncl = double.Parse(ItemDGV.CurrentRow.Cells[4].Value.ToString()),
                rowIndex = ItemDGV.CurrentRow.Index
            };

            OrderItem orderItem = new OrderItem(OrderData, this);
            orderItem.orderDGV = ItemDGV;
            orderItem.txtOrderTotalExcl = TxtTotalExcl;
            orderItem.txtOrderVAT = TxtVat;
            orderItem.txtOrderTotalIncl = TxtOrderTotal;
            orderItem.btnEditItem = BtnEdit;
            orderItem.btnDeleteItem = BtnDelete;
            orderItem.btnConfirmOrder = BtnSubmit;
            orderItem.vatExclusive = VatExcluded;
            orderItem.vatInclusive = VatIncluded;
            _ = orderItem.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ItemDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult deleteResult = MessageBox.Show("Are you sure you want delete the selected item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleteResult == DialogResult.Yes)
                {
                    double orderTotalExcl = double.Parse(TxtTotalExcl.Text.Substring(1));
                    //double orderVAT = double.Parse(txtVat.Text.Substring(1));
                    double orderTotalIncl = double.Parse(TxtOrderTotal.Text.Substring(1));

                    double itemTotalExcl = double.Parse(ItemDGV.CurrentRow.Cells[3].Value.ToString());
                    double itemTotalIncl = double.Parse(ItemDGV.CurrentRow.Cells[4].Value.ToString());

                    orderTotalExcl -= itemTotalExcl;
                    double orderVAT = orderTotalExcl * .15;
                    orderTotalIncl -= itemTotalIncl;

                    ItemDGV.Rows.RemoveAt(ItemDGV.CurrentRow.Index);
                    TxtTotalExcl.Text = orderTotalExcl.ToString("C2");
                    TxtVat.Text = orderVAT.ToString("C2");
                    TxtOrderTotal.Text = orderTotalIncl.ToString("C2");
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
                BtnSubmit.Enabled = false;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ItemDGV.Rows.Count == 0)
            {
                _ = MessageBox.Show("An empty order cannot be captured", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ = BtnAdd.Focus();
            }
            else
            {
                string orderNumber = TxtOrderNumber.Text;
                string supplierID = CmbSupplier.SelectedValue.ToString();
                DateTime orderDate = DateTime.Parse(TxtOrderDate.Text);
                string invoiceNumber = "";
                DateTime? invoiceDate = null;
                if (TxtInvoiceNumber.Text.Length > 0)
                {
                    invoiceNumber = TxtInvoiceNumber.Text;
                }

                if (RadPaidYes.Checked == true)
                {
                    invoiceDate = DateTime.Parse(DateInvoiceDate.Value.ToString("yyyy/MM/dd"));
                }
                _ = new Order(orderNumber, supplierID, orderDate, ItemDGV, invoiceNumber, invoiceDate);

                TxtTotalExcl.Text = "";
                TxtVat.Text = "";
                TxtOrderTotal.Text = "";
                ItemDGV.Rows.Clear();
                Close();
                Mainform.FillOrdersGrid();
            }
        }

        private void RadPaidYes_CheckedChanged(object sender, EventArgs e)
        {
            if (RadPaidYes.Checked == true)
            {
                TxtInvoiceNumber.Enabled = true;
                DateInvoiceDate.Enabled = true;
            }
            else
            {
                TxtInvoiceNumber.Enabled = false;
                DateInvoiceDate.Enabled = false;
            }
        }        
    }
}
