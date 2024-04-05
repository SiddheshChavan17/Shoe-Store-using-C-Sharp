using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalShoeStore
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void Prologout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pro_add_show_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();

        }

        private void Resetprobt_Click(object sender, EventArgs e)
        {
            up_pro_name.Text = string.Empty;
            up_pro_brand.Text = string.Empty;
            up_pro_id.Text = string.Empty;
            up_pro_price.Text = string.Empty;
            up_pro_quan.Text = string.Empty;
        }

        private void Pro_fetch_show_Click(object sender, EventArgs e)
        {
            FetchProduct fetchProduct = new FetchProduct();
            fetchProduct.Show();
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\ProductDB.accdb"))
            {
                connection.Open();

                string query = "SELECT Product_ID, Product_Name, Brand, Quantity, Price FROM product WHERE Product_ID = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", up_pro_id.Text);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            up_pro_name.Text = reader["Product_Name"].ToString();
                            up_pro_brand.Text = reader["Brand"].ToString();
                            up_pro_quan.Text = reader["Quantity"].ToString();
                            up_pro_price.Text = reader["Price"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Product ID not found.");
                        }
                    }
                }
            }
        }

        private void Upprobt_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\ProductDB.accdb"))
            {
                connection.Open();

                string updateQuery = "UPDATE product SET Product_Name=@ProductName, Brand=@Brand, Quantity=@Quantity, Price=@Price WHERE Product_ID=@ProductID";
                using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@ProductName", up_pro_name.Text);
                    updateCommand.Parameters.AddWithValue("@Brand", up_pro_brand.Text);
                    updateCommand.Parameters.AddWithValue("@Quantity", up_pro_quan.Text);
                    updateCommand.Parameters.AddWithValue("@Price", up_pro_price.Text);
                    updateCommand.Parameters.AddWithValue("@ProductID", up_pro_id.Text);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Product.");
                    }
                }
            }
        }
    }
}
