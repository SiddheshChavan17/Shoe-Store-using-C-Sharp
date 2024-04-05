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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void Add_emp_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emp_add_show_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Close();
        }

        private void Emplogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee =new AddEmployee();
            addEmployee.Show();
            this.Close();
        }

        private void Resetempbt_Click(object sender, EventArgs e)
        {
            up_emp_addr.Text=string.Empty;
            up_emp_cn.Text=string.Empty;
            up_emp_id.Text=string.Empty;
            up_emp_mail.Text=string.Empty;
            up_emp_name.Text=string.Empty;
        }

        private void Emp_fetch_show_Click(object sender, EventArgs e)
        {
            FetchEmployee fetchEmployee = new FetchEmployee();
            fetchEmployee.Show();
            this.Close();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\EmployeeDB.accdb"))
            {
                connection.Open();

                string query = "SELECT Emp_ID, Emp_Name, Contact, [E-Mail], Address FROM employee WHERE Emp_ID = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", up_emp_id.Text);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            up_emp_name.Text = reader["Emp_Name"].ToString();
                            up_emp_cn.Text = reader["Contact"].ToString();
                            up_emp_mail.Text = reader["E-Mail"].ToString();
                            up_emp_addr.Text = reader["Address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer ID not found.");
                        }
                    }
                }
            }
        }

        private void Updateempbt_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\EmployeeDB.accdb"))
            {
                connection.Open();

                string updateQuery = "UPDATE employee SET Emp_Name=@EmpName, Contact=@Contact, [E-mail]=@Email, Address=@Address WHERE Emp_ID=@EmpID";
                using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@EmpName", up_emp_name.Text);
                    updateCommand.Parameters.AddWithValue("@Contact", up_emp_cn.Text);
                    updateCommand.Parameters.AddWithValue("@Email", up_emp_mail.Text);
                    updateCommand.Parameters.AddWithValue("@Address", up_emp_addr.Text);
                    updateCommand.Parameters.AddWithValue("@EmpID", up_emp_id.Text);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Employee.");
                    }
                }
            }
        }
    }
}
