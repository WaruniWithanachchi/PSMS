using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Pet_Shop_Management_System
{
    internal class ProductData
    {
        public int Product_Code { get; set; }
        public string Product_Name { get; set; }
        public string Product_Type { get; set; }
        public string Product_Category { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        // Connection string
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\KDU\Second year\Modules\RAD\Project\Pet Shop Management System\Pet Shop Management System\PetShopdb.mdf"";Integrated Security=True";

        public bool AddProductToDatabase()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    string query = @"INSERT INTO Products (Product_Code, Product_Name, Product_Type, Product_Category, Quantity) VALUES (@ProductCode, @ProductName, @ProductType, @ProductCategory, @Quantity)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Add parameters to avoid SQL Injection
                        cmd.Parameters.AddWithValue("@ProductCode", Product_Code);
                        cmd.Parameters.AddWithValue("@ProductName", Product_Name);
                        cmd.Parameters.AddWithValue("@ProductType", Product_Type);
                        cmd.Parameters.AddWithValue("@ProductCategory", Product_Category);
                        cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public List<ProductData> ProductsListData()
        {
            List<ProductData> listdata = new List<ProductData>();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM Products WHERE delete_date IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                ProductData data = new ProductData()
                                {
                                    Product_Code = (int)reader["product_code"],
                                    Product_Name = reader["product_name"].ToString(),
                                    Product_Type = reader["product_type"].ToString(),
                                    Product_Category = reader["product_category"].ToString(), // Ensure this column name matches your database
                                    Quantity = (int)reader["quantity"],
                                    // Use Convert.ToDouble for safer type conversion
                                };

                                listdata.Add(data);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            return listdata;
        }
    }
}
