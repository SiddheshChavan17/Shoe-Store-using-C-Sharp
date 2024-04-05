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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
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

        private void Resetsupbt_Click(object sender, EventArgs e)
        {
            add_sup_addr.Text = string.Empty;
            add_sup_cn.Text = string.Empty;
            add_sup_id.Text = string.Empty;
            add_sup_name.Text = string.Empty;
            add_sup_po.Text = string.Empty;
        }

        private void Sup_upd_show_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.Show();
            this.Close();
        }

        private void Sup_fetch_show_Click(object sender, EventArgs e)
        {
            FetchSupplier fetchSupplier = new FetchSupplier();
            fetchSupplier.Show();
            this.Close();
        }

        private void Addsupbt_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\SupplierDB.accdb"
            };

            connection.Open();

            OleDbCommand command = new OleDbCommand
            {
                Connection = connection,

                CommandText = "INSERT INTO supplier (Supplier_ID, Supplier_Name, Products_offered, Contact_Number, Address) " +
                     "VALUES ('" + add_sup_id.Text + "','" + add_sup_name.Text + "','" + add_sup_po.Text + "','" + add_sup_cn.Text + "','" + add_sup_addr.Text + "')"
            };
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Supplier has been Added Successfully !");
        }

        private void Add_sup_name_TextChanged(object sender, EventArgs e)
        {
            string enteredText = add_sup_name.Text;

            // Check if the text contains anything other than letters
            if (enteredText.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid name (letters only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_sup_name.Text = ""; // Clear the text box.
            }
        }
    }
}
