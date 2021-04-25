using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Altered
{
    public partial class EditForm : Form
    {

        private Form1 Mainform = null;

        private readonly UpdateData editData;
        public EditForm(UpdateData EditData, Form callingForm)
        {
            Mainform = callingForm as Form1;
            InitializeComponent();
            editData = EditData;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            Text = editData.header;
            string query = "SELECT * FROM " + editData.table + " WHERE " + editData.column + " = '" + editData.ID + "'";
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
                            TxtID.Text = editData.ID;
                            TxtCompany.Text = sdr["company"].ToString();
                            TxtRepName.Text = sdr["rep_name"].ToString();
                            TxtEmail.Text = sdr["email"].ToString();
                            TxtTelephone.Text = sdr["telephone"].ToString();
                            TxtCellphone.Text = sdr["cellphone"].ToString();
                            TxtRegNumber.Text = sdr["registration"].ToString();
                            TxtAddress.Text = sdr["address"].ToString();
                            TxtPostal.Text = sdr["postal_code"].ToString();
                            if (char.Parse(sdr["registered"].ToString()) == 'Y')
                            {
                                RadVatYes.Checked = true;
                            }
                            else
                            {
                                RadVatNo.Checked = true;
                            }
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

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (TxtCompany.Text == "" && TxtRepName.Text == "")
            {
                _ = MessageBox.Show("Supplier and Rep name are both empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _ = TxtCompany.Focus();
            }
            else if (TxtEmail.Text == "" && TxtTelephone.Text == "" && TxtCellphone.Text == "")
            {
                _ = MessageBox.Show("Supplier must have at least one contact method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtEmail.Focus();
            }
            else if (TxtEmail.Text != "" && RegexUtilities.IsValidEmail(TxtEmail.Text) == false)
            {
                _ = MessageBox.Show(TxtEmail.Text + " is not a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtEmail.Focus();
                TxtEmail.SelectAll();
            }
            else if (TxtPostal.Text != "" && ValidateIntegers(TxtPostal.Text) == false)
            {
                _ = MessageBox.Show("Invalid postal code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtAddress.Focus();
            }
            else if (TxtPostal.Text == "" && TxtAddress.Text != "")
            {
                _ = MessageBox.Show("Missing postal code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtPostal.Focus();
            }
            else
            {
                char vat_registered;
                if (RadVatYes.Checked == true)
                {
                    vat_registered = 'Y';
                }
                else
                {
                    vat_registered = 'N';
                }

                if (editData.ID.Substring(0, 4) == "TMTS")
                {
                    _ = new Supplier(TxtID.Text, TxtCompany.Text, TxtRepName.Text, TxtEmail.Text, TxtTelephone.Text, TxtCellphone.Text, TxtRegNumber.Text, vat_registered, TxtAddress.Text, TxtPostal.Text, true);
                    Mainform.FillSupplierGrid();
                }
                else if (editData.ID.Substring(0, 4) == "TMTC")
                {
                    _ = new Customer(TxtID.Text, TxtCompany.Text, TxtRepName.Text, TxtEmail.Text, TxtTelephone.Text, TxtCellphone.Text, TxtRegNumber.Text, vat_registered, TxtAddress.Text, TxtPostal.Text, true);
                    Mainform.FillCustomerGrid();
                }
                Close();
            }
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
    }
}
