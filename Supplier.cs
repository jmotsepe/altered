using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Altered
{
    class Supplier
    {
        private string SupplierID { get; set; }
        private string Company { get; set; }
        private string Rep_Name { get; set; }
        private string Email { get; set; }
        private string Telephone { get; set; }
        private string Cellphone { get; set; }
        private string Registration { get; set; }
        private char Vat_Registered { get; set; }
        private string Address { get; set; }
        private string Postal { get; set; }
        private bool Edit { get; set; }
        private string Stored_Procedure { get; set; }

        public Supplier()
        {

        }

        public Supplier(string supplierID, string company, string rep_name, string email, string telephone, string cellphone, string registration, char vat_registered, string address, string postal_code, bool editSupplier)
        {
            SupplierID = supplierID;
            Company = company;
            Rep_Name = rep_name;
            Email = email;
            Telephone = telephone;
            Cellphone = cellphone;
            Registration = registration;
            Vat_Registered = vat_registered;
            Address = address;
            Postal = postal_code;
            Edit = editSupplier;

            if (Edit == false)
            {
                Stored_Procedure = "sp_addSupplier";
            }
            else if (Edit == true)
            {
                Stored_Procedure = "sp_editSupplier";
            }
            ConfirmSupplier();
        }

        private void ConfirmSupplier()
        {
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(Stored_Procedure, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@supplierID", SqlDbType.VarChar).Value = SupplierID;
                    cmd.Parameters.AddWithValue("@company", SqlDbType.VarChar).Value = Company;
                    cmd.Parameters.AddWithValue("@rep_name", SqlDbType.VarChar).Value = Rep_Name;
                    cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = Email;
                    cmd.Parameters.AddWithValue("@telephone", SqlDbType.VarChar).Value = Telephone;
                    cmd.Parameters.AddWithValue("@cellphone", SqlDbType.VarChar).Value = Cellphone;
                    cmd.Parameters.AddWithValue("@registration", SqlDbType.VarChar).Value = Registration;
                    cmd.Parameters.AddWithValue("@registered", SqlDbType.Char).Value = Vat_Registered;
                    cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = Address;
                    cmd.Parameters.AddWithValue("@postal_code", SqlDbType.VarChar).Value = Postal;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        if (Stored_Procedure == "sp_addSupplier")
                        {
                            MessageBox.Show("Supplier added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            _ = MessageBox.Show("Supplier was successfuly updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
