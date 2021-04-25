using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Altered
{
    public partial class EditSupplier : Form
    {
        private Form1 Mainform = null;

        private readonly UpdateSupplier supplierData;
        public EditSupplier(UpdateSupplier SupplierData, Form callingForm)
        {
            Mainform = callingForm as Form1;
            InitializeComponent();
            supplierData = SupplierData;
        }

        private void EditSupplier_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblCupplier WHERE supplierID = '" + supplierData.supplierID + "'";
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
                            TxtSupplierID.Text = supplierData.supplierID;
                            TxtCompany.Text = sdr["company"].ToString();
                            TxtRepName.Text = sdr["rep_name"].ToString();
                            TxtSupplierEmail.Text = sdr["email"].ToString();
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
            else if (TxtSupplierEmail.Text == "" && TxtTelephone.Text == "" && TxtCellphone.Text == "")
            {
                _ = MessageBox.Show("Supplier must have at least one contact method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtSupplierEmail.Focus();
            }
            else if (TxtSupplierEmail.Text != "" && RegexUtilities.IsValidEmail(TxtSupplierEmail.Text) == false)
            {
                _ = MessageBox.Show(TxtSupplierEmail.Text + " is not a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtSupplierEmail.Focus();
                TxtSupplierEmail.SelectAll();
            }
            else if (TxtAddress.Text == "")
            {
                _ = MessageBox.Show("Address cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ = TxtAddress.Focus();
            }
            else if ((TxtPostal.Text == "" && TxtAddress.Text != "") || ValidateIntegers(TxtPostal.Text) == false)
            {
                _ = MessageBox.Show("Invalid postal code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                _ = new Supplier(TxtSupplierID.Text, TxtCompany.Text, TxtRepName.Text, TxtSupplierEmail.Text, TxtTelephone.Text, TxtCellphone.Text, TxtRegNumber.Text, vat_registered, TxtAddress.Text, TxtPostal.Text, true);
                Mainform.FillSupplierGrid();
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
