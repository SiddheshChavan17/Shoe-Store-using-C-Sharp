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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Close();
        }

        private void Cus_add_show_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Close();
        }

        private void Cus_fetch_show_Click(object sender, EventArgs e)
        {
            FetchCustomer fetchCustomer = new FetchCustomer();
            fetchCustomer.Show();
            this.Close();
        }

        private void Resetcusbt_Click(object sender, EventArgs e)
        {
            upd_cus_addr.Text = string.Empty;
            upd_cus_cn.Text = string.Empty;
            upd_cus_id.Text = string.Empty;
            upd_cus_mail.Text = string.Empty;
            upd_cus_name.Text = string.Empty;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\CustomerDB.accdb"))
            {
                connection.Open();

                string query = "SELECT Customer_ID, Customer_Name, Contact_Number, [E-Mail], Address FROM customer WHERE Customer_ID = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", upd_cus_id.Text);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            upd_cus_name.Text = reader["Customer_Name"].ToString();
                            upd_cus_cn.Text = reader["Contact_Number"].ToString();
                            upd_cus_mail.Text = reader["E-Mail"].ToString();
                            upd_cus_addr.Text = reader["Address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer ID not found.");
                        }
                    }
                }
            }
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void Upd_cus_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Upd_cus_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Upd_cus_mail_Validating(object sender, CancelEventArgs e)
        {
            string emailPattern = @"\b[A-Za-z0-9._%+-]+@gmail\.com\b";
            if (!System.Text.RegularExpressions.Regex.IsMatch(upd_cus_mail.Text, emailPattern))
            {
                e.Cancel = true;
                MessageBox.Show("Email should be of the format user@gmail.com.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Updatecusbt_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\CustomerDB.accdb"))
            {
                connection.Open();

                string updateQuery = "UPDATE customer SET Customer_Name=@Name, Contact_Number=@Contact, [E-mail]=@Email, Address=@Address WHERE Customer_ID=@ID";
                using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Name", upd_cus_name.Text);
                    updateCommand.Parameters.AddWithValue("@Contact", upd_cus_cn.Text);
                    updateCommand.Parameters.AddWithValue("@Email", upd_cus_mail.Text);
                    updateCommand.Parameters.AddWithValue("@Address", upd_cus_addr.Text);
                    updateCommand.Parameters.AddWithValue("@ID", upd_cus_id.Text); // Assuming this is the unique identifier for the customer to update.

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Customer.");
                    }
                }
            }
        }
    }
}
