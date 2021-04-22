using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Altered
{
    public partial class Login : Form
    {

        public static string username;
        public static string password;
        public static bool Success { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                _ = MessageBox.Show("Please enter usename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUsername.Focus();
                return;
            }
            else if (TxtPassword.Text == "")
            {
                _ = MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Focus();
                return;
            }
            else
            {
                username = TxtUsername.Text;
                password = TxtPassword.Text;

                string cs = "Data Source=HPC0028568\\SQLEXPRESS;Initial Catalog=altered;Persist Security Info=True;User ID="+ username + ";Password=" + password;
                try
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();
                        if (con.State == ConnectionState.Closed)
                        {
                            _ = MessageBox.Show("Login Failed... Try again!", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            TxtUsername.Clear();
                            TxtPassword.Clear();
                            TxtUsername.Focus();
                        }
                        else
                        {
                            Hide();                            
                        }

                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ = MessageBox.Show("Login Failed... Try again!", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    TxtUsername.Clear();
                    TxtPassword.Clear();
                    TxtUsername.Focus();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }
    }
}
