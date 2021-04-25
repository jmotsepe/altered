using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altered
{
    class Customer
    {
        private string CustomerID { get; set; }
        private string Company { get; set; }
        private string Rep_Name { get; set; }
        private string Email { get; set; }
        private string Telephone { get; set; }
        private string Cellphone { get; set; }
        private string Registration { get; set; }
        private char Registered { get; set; }
        private string Address { get; set; }
        private string Postal_Code { get; set; }
        private bool Edit { get; set; }
        private string Stored_Procedure { get; set; }

        public Customer()
        {

        }

        public Customer(string customerID, string company, string rep_name, string email, string telephone, string cellphone, string registration, char registered, string address, string postal_code, bool edit)
        {
            CustomerID = customerID;
            Company = company;
            Rep_Name = rep_name;
            Email = email;
            Telephone = telephone;
            Cellphone = cellphone;
            Registration = registration;
            Registered = registered;
            Address = address;
            Postal_Code = postal_code;
            Edit = edit;

            if (Edit == false)
            {
                Stored_Procedure = "sp_addCustomer";
            }
            else if (Edit == true)
            {
                Stored_Procedure = "sp_editCustomer";
            }
            ConfirmCustomer();
        }

        private void ConfirmCustomer()
        {
            using(SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using(SqlCommand cmd = new SqlCommand(Stored_Procedure, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", SqlDbType.VarChar).Value = CustomerID;
                    cmd.Parameters.AddWithValue("@company", SqlDbType.VarChar).Value = Company;
                    cmd.Parameters.AddWithValue("@rep_name", SqlDbType.VarChar).Value = Rep_Name;
                    cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = Email;
                    cmd.Parameters.AddWithValue("@telephone", SqlDbType.VarChar).Value = Telephone;
                    cmd.Parameters.AddWithValue("@cellphone", SqlDbType.VarChar).Value = Cellphone;
                    cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = Address;
                    cmd.Parameters.AddWithValue("@postal_code", SqlDbType.VarChar).Value = Postal_Code;
                    cmd.Parameters.AddWithValue("@registration", SqlDbType.VarChar).Value = Registration;
                    cmd.Parameters.AddWithValue("@registered", SqlDbType.Char).Value = Registered;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        if (Stored_Procedure == "sp_addCustomer")
                        {
                            MessageBox.Show("Customer added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Customer successfuly updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
