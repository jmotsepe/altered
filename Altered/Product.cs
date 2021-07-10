using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Altered
{
    internal class Product
    {
        private string Description { get; set; }
        private double CostPrice { get; set; }
        private double SellingPrice { get; set; }
        private string Location { get; set; }
        private bool Edit { get; set; }
        private int ProductID { get; set; }
        private string Code { get; set; }

        public Product(string description, double costPrice, double sellingPrice, string location, bool edit)
        {
            Description = description;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            Location = location;
            Edit = edit;
            Code = GenerateCode();

            AddProduct();
        }

        public Product(int productID, string description, double costPrice, double sellingPrice, string location, bool edit)
        {
            ProductID = productID;
            Description = description;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            Location = location;
            Edit = edit;

            EditProduct();
        }

        private void AddProduct()
        {
            string storedProc = "sp_addProducts";

            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(storedProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = Description;
                    cmd.Parameters.AddWithValue("@code", SqlDbType.VarChar).Value = Code;
                    cmd.Parameters.AddWithValue("@cost_price", SqlDbType.Float).Value = CostPrice;
                    cmd.Parameters.AddWithValue("@selling_price", SqlDbType.Float).Value = SellingPrice;
                    cmd.Parameters.AddWithValue("@imageLocation", SqlDbType.VarChar).Value = Location;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void EditProduct()
        {
            string storedProc = "sp_editProducts";
            using (SqlConnection con = new SqlConnection(Connection.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(storedProc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productID", SqlDbType.Int).Value = ProductID;
                    cmd.Parameters.AddWithValue("@description", SqlDbType.VarChar).Value = Description;
                    cmd.Parameters.AddWithValue("@cost_price", SqlDbType.Float).Value = CostPrice;
                    cmd.Parameters.AddWithValue("@selling_price", SqlDbType.Float).Value = SellingPrice;
                    cmd.Parameters.AddWithValue("@imageLocation", SqlDbType.VarChar).Value = Location;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (SqlException ex)
                    {
                        _ = MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private static Random random = new Random();
        private string GenerateCode()
        {
            int length = 8;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}