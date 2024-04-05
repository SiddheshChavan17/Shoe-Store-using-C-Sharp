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
using System.Xml.Linq;

namespace FinalShoeStore
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FetchCustomer fetchCustomer1 = new FetchCustomer();
            fetchCustomer1.Show();
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            this.Close();
        }

        private void Cus_update_show_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
            this.Close();
        }

        private void Resetcusbt_Click(object sender, EventArgs e)
        {
            add_cus_addr.Text = string.Empty;
            add_cus_cn.Text = string.Empty;
            add_cus_id.Text = string.Empty;
            add_cus_mail.Text = string.Empty;
            add_cus_name.Text = string.Empty;
        }

        private void Addcusbt_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\CustomerDB.accdb"
            };

            connection.Open();

            // Validate email format
            if (!add_cus_mail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter a valid Gmail address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_cus_mail.Text = ""; // Clear the text box.
                connection.Close();
                return; // Don't proceed with the insert.
            }

            OleDbCommand command = new OleDbCommand
            {
                Connection = connection,

                CommandText = "INSERT INTO customer (Customer_ID, Customer_Name, Contact_Number, [E-Mail], Address) " +
                     "VALUES ('" + add_cus_id.Text + "','" + add_cus_name.Text + "','" + add_cus_cn.Text + "','" + add_cus_mail.Text + "','" + add_cus_addr.Text + "')"
            };
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Customer has been Added Successfully !");
        }

        private void Add_cus_id_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void Add_cus_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input or the backspace key (for deletion)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // This will block the input.
            }
        }

        private void Add_cus_name_TextChanged(object sender, EventArgs e)
        {
            string enteredText = add_cus_name.Text;

            // Check if the text contains anything other than letters
            if (enteredText.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid name (letters only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_cus_name.Text = ""; // Clear the text box.
            }
        }
    }
}

