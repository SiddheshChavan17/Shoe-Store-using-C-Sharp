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
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
            this.Close();
        }

        private void Resetsupbt_Click(object sender, EventArgs e)
        {
            up_sup_cn.Text = string.Empty;
            up_sup_addr.Text = string.Empty;
            up_sup_id.Text = string.Empty;
            up_sup_name.Text = string.Empty;
            up_sup_po.Text = string.Empty;
        }

        private void Suplogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sup_add_show_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier1 = new AddSupplier();
            addSupplier1.Show();
            this.Close();
        }

        private void Sup_fetch_show_Click(object sender, EventArgs e)
        {
            FetchSupplier fetchSupplier = new FetchSupplier();
            fetchSupplier.Show();
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\SupplierDB.accdb"))
            {
                connection.Open();

                string query = "SELECT Supplier_ID, Supplier_Name, Products_offered, Contact_Number, Address FROM supplier WHERE Supplier_ID = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", up_sup_id.Text);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            up_sup_name.Text = reader["Supplier_Name"].ToString();
                            up_sup_po.Text = reader["Products_offered"].ToString();
                            up_sup_cn.Text = reader["Contact_Number"].ToString();
                            up_sup_addr.Text = reader["Address"].ToString();
                        }
                        else
                        {
                            _ = MessageBox.Show("Supplier ID not found.");
                        }
                    }
                }
            }
        }

        private void Addsupbt_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\SupplierDB.accdb"))
            {
                connection.Open();

                string updateQuery = "UPDATE supplier SET Supplier_Name=@Name, Products_offered=@ProductsOffered, Contact_Number=@Contact, Address=@Address WHERE Supplier_ID=@ID";
                using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Name", up_sup_name.Text);
                    updateCommand.Parameters.AddWithValue("@ProductsOffered", up_sup_po.Text);
                    updateCommand.Parameters.AddWithValue("@Contact", up_sup_cn.Text);
                    updateCommand.Parameters.AddWithValue("@Address", up_sup_addr.Text);
                    updateCommand.Parameters.AddWithValue("@ID", up_sup_id.Text); // Assuming this is the unique identifier for the customer to update.

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Supplier updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Supplier.");
                    }
                }
            }
        }
    }
}
