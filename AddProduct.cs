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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            this.Close();
        }

        private void Prologout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resetprobt_Click(object sender, EventArgs e)
        {
            add_pro_name.Text = string.Empty;
            add_pro_brand.Text = string.Empty;
            add_pro_id.Text = string.Empty;
            add_pro_price.Text = string.Empty;
            add_pro_quan.Text = string.Empty;
        }

        private void Pro_upd_show_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
            this.Close();
        }

        private void Pro_fetch_show_Click(object sender, EventArgs e)
        {
            FetchProduct fetchProduct = new FetchProduct();
            fetchProduct.Show();
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void Addprobt_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\ProductDB.accdb"
            };

            connection.Open();

            OleDbCommand command = new OleDbCommand
            {
                Connection = connection,

                CommandText = "INSERT INTO product (Product_ID, Product_Name, Brand, Quantity, Price) " +
                     "VALUES ('" + add_pro_id.Text + "','" + add_pro_name.Text + "','" + add_pro_brand.Text + "','" + add_pro_quan.Text + "','" + add_pro_price.Text + "')"
            };
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Product has been Added Successfully !");
        }

        private void Add_pro_name_TextChanged(object sender, EventArgs e)
        {
            string enteredText = add_pro_name.Text;

            // Check if the text contains anything other than letters
            if (enteredText.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid name (letters only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_pro_name.Text = ""; // Clear the text box.
            }
        }
    }
}
