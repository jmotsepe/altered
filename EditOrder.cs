using System;
using System.Windows.Forms;

namespace Altered
{
    public partial class EditOrder : Form
    {
        private Form1 Mainform = null;

        private readonly UpdateOrder orderData;

        public EditOrder(UpdateOrder OrderData, Form callingForm)
        {
            Mainform = callingForm as Form1;
            InitializeComponent();
            orderData = OrderData;
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            LblOrderNumber.Text = orderData.order_number;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (TxtInvoiceNumber.Text != "")
            {
                string order_number = orderData.order_number;
                string invoice_number = TxtInvoiceNumber.Text;
                DateTime invoice_date = DateInvoiceDate.Value;

                _ = new Order(order_number, invoice_number, invoice_date);
            }
            Close();
        }
    }
}
