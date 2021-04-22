using System;
using System.Windows.Forms;

namespace Altered
{
    public partial class OrderItem : Form
    {
        private Form1 Mainform = null;
        public DataGridView orderDGV { get; set; }
        public TextBox txtOrderTotalExcl { get; set; }
        public TextBox txtOrderTotalIncl { get; set; }
        public TextBox txtOrderVAT { get; set; }
        public Button btnEditItem { get; set; }
        public Button btnDeleteItem { get; set; }
        public Button btnConfirmOrder { get; set; }
        public RadioButton vatInclusive { get; set; }
        public RadioButton vatExclusive { get; set; }

        public OrderItem()
        {
            InitializeComponent();
        }

        private readonly UpdateOrderItem orderData;

        public OrderItem(UpdateOrderItem OrderData, Form callingForm)
        {
            InitializeComponent();
            Mainform = callingForm as Form1;
            orderData = OrderData;
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {
            VatExcluded.Enabled = false;
            VatIncluded.Enabled = false;
            if (vatExclusive.Checked == true)
            {
                VatExcluded.Checked = true;
            }
            else
            {
                VatIncluded.Checked = true;
            }



            if (orderData != null)
            {
                TxtDescription.Text = orderData.lineDesc;
                TxtPrice.Text = orderData.linePrice.ToString();
                TxtQuantity.Value = orderData.lineQuantity;

                Text = "Edit Order Item";
            }
            else
            {
                Text = "Add Order Item";
            }
        }

        private void BtnConfirm_Click_1(object sender, EventArgs e)
        {
            string descr = TxtDescription.Text;
            double price = 0;
            int quantity = int.Parse(TxtQuantity.Value.ToString());

            if (ValidateDoubles(TxtPrice.Text) == true)
            {
                price = double.Parse(TxtPrice.Text);
                double lineTotalExcl = 0;
                double lineTotalIncl = 0;
                if (VatExcluded.Checked == true)
                {
                    lineTotalExcl = Math.Round(quantity * price, 2);
                    lineTotalIncl = Math.Round(lineTotalExcl * 1.15, 2);
                }
                else if (VatExcluded.Checked == false)
                {
                    lineTotalExcl = Math.Round(quantity * price, 2);
                    lineTotalIncl = lineTotalExcl;
                    lineTotalExcl = Math.Round((lineTotalExcl / 115) * 100, 2);
                    price = lineTotalExcl;
                }

                if (orderData != null)
                {
                    foreach (DataGridViewRow row in orderDGV.Rows)
                    {
                        orderDGV.Rows.RemoveAt(orderData.rowIndex);
                        orderDGV.Rows.Insert(orderData.rowIndex, quantity.ToString(), descr, price.ToString(), lineTotalExcl.ToString(), lineTotalIncl.ToString());
                    }
                }
                else
                {
                    orderDGV.Rows.Add(quantity.ToString(), descr, price.ToString(), lineTotalExcl.ToString(), lineTotalIncl.ToString());
                }

                CalculateOrderTotals();
                if (btnEditItem.Enabled == false) btnEditItem.Enabled = true;
                if (btnDeleteItem.Enabled == false) btnDeleteItem.Enabled = true;
                if (btnConfirmOrder.Enabled == false) btnConfirmOrder.Enabled = true;
                if (vatInclusive.Enabled == true) vatInclusive.Enabled = false;
                if (vatExclusive.Enabled == true) vatExclusive.Enabled = false;
                Close();
            }
            else
            {
                _ = MessageBox.Show("Price is not in correct format. Remove any none numeric character and make sure that the correct decimal separator is being used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPrice.Focus();
                TxtPrice.SelectAll();
            }           
        }

        private void CalculateOrderTotals()
        {
            double orderTotalExcl = 0;
            double orderVAT = 0;
            double orderTotalIncl = 0;

            foreach (DataGridViewRow row in orderDGV.Rows)
            {
                orderTotalExcl += double.Parse(row.Cells[3].Value.ToString());
            }

            if (VatExcluded.Checked == false)
            {
                orderVAT = orderTotalExcl * .15;
                orderTotalIncl = orderTotalExcl * 1.15;
            }
            else
            {
                orderVAT = Math.Round(orderTotalExcl * .15, 2);
                orderTotalIncl = orderTotalExcl + orderVAT;
            }
            txtOrderTotalExcl.Text = orderTotalExcl.ToString("C2");
            txtOrderVAT.Text = orderVAT.ToString("C2");
            txtOrderTotalIncl.Text = orderTotalIncl.ToString("C2");
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
    }
}
