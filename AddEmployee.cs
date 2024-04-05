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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            this.Close();
        }

        private void Emplogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resetempbt_Click(object sender, EventArgs e)
        {
            add_emp_addr.Text = string.Empty;
            add_emp_cn.Text = string.Empty;
            add_emp_id.Text = string.Empty;
            add_emp_mail.Text = string.Empty;
            add_emp_name.Text = string.Empty;
        }

        private void Emp_fetch_show_Click(object sender, EventArgs e)
        {
            FetchEmployee fetchEmployee = new FetchEmployee();
            fetchEmployee.Show();
            this.Close();
        }

        private void Emp_upd_show_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
            this.Close();
        }

        private void Updateempbt_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection
            {
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\EmployeeDB.accdb"
            };

            connection.Open();

            // Validate email format
            if (!add_emp_mail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please enter a valid Gmail address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_emp_mail.Text = ""; // Clear the text box.
                connection.Close();
                return; // Don't proceed with the insert.
            }

            OleDbCommand command = new OleDbCommand
            {
                Connection = connection,

                CommandText = "INSERT INTO employee (Emp_ID, Emp_Name, Contact, [E-Mail], Address) " +
                     "VALUES ('" + add_emp_id.Text + "','" + add_emp_name.Text + "','" + add_emp_cn.Text + "','" + add_emp_mail.Text + "','" + add_emp_addr.Text + "')"
            };
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Employee has been Added Successfully !");
        }

        private void Add_emp_name_TextChanged(object sender, EventArgs e)
        {
            string enteredText = add_emp_name.Text;

            // Check if the text contains anything other than letters
            if (enteredText.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid name (letters only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_emp_name.Text = ""; // Clear the text box.
            }
        }
    }
}
