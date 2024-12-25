using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace Pet_Shop_Management_System
{
    public partial class AddProduct : UserControl
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\KDU\Second year\Modules\RAD\Project\Pet Shop Management System\Pet Shop Management System\PetShopdb.mdf"";Integrated Security=True";

        private SqlConnection connect; // Declare SqlConnection variable

        public AddProduct()
        {
            InitializeComponent();

            connect = new SqlConnection(connectionString); // Initialize SqlConnection with the connection string

            displayProductData();  //to display the data from the data base to the data grid view
        }

        public void displayProductData()
        {
            ProductData data = new ProductData();
            List<ProductData> listdata = data.ProductsListData();

            dataGridView1.DataSource = listdata;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the connection is open
                    if (connection.State == ConnectionState.Open)
                    {
                        string checkPrCode = "SELECT COUNT(*) FROM Products WHERE product_code = @prCode";

                        using (SqlCommand checkCmd = new SqlCommand(checkPrCode, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@prCode", textBox3.Text.Trim());

                            int count = (int)checkCmd.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(textBox3.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Exit the method if product code already exists
                            }
                        }

                        // Prepare the INSERT query
                        string insertData = "INSERT INTO Products (product_code, product_name, product_type, product_category, quantity, price, insert_date)" +
                                            " VALUES (@productcode, @productname, @producttype, @productcategory, @quantity, @price, @insertDate)";

                        // Create and execute the INSERT command
                        using (SqlCommand cmd = new SqlCommand(insertData, connection))
                        {
                            cmd.Parameters.AddWithValue("@productcode", textBox3.Text.Trim());
                            cmd.Parameters.AddWithValue("@productname", textBox6.Text.Trim());
                            cmd.Parameters.AddWithValue("@producttype", textBox5.Text.Trim());
                            cmd.Parameters.AddWithValue("@productcategory", comboBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("@quantity", int.Parse(textBox2.Text.Trim())); // Assuming quantity is an integer
                            cmd.Parameters.AddWithValue("@price", float.Parse(textBox4.Text.Trim())); // Assuming price is a float
                            cmd.Parameters.AddWithValue("@insertDate", DateTime.Today);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                displayProductData(); // Refresh the product list in the DataGridView
                                MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

