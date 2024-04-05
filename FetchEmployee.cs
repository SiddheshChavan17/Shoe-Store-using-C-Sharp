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
    public partial class FetchEmployee : Form
    {
        public FetchEmployee()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection();
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
            this.Close();
        }

        private void Emplogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Emp_add_show_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Close();
        }

        private void Emp_upd_show_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee= new UpdateEmployee();
            updateEmployee.Show();
            this.Close();
        }

        private void FetchEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDBDataSet.employee);

            // TODO: This line of code loads data into the 'medDatabaseDataSet.SupplierTB' table. You can move, or remove it, as needed.
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\EmployeeDB.accdb";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            // Assuming you have a table named 'YourTableName'
            string selectQuery = "SELECT * FROM employee";
            // Create a data adapter
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectQuery, conn);
            // Create a DataTable to hold the results
            DataTable dataTable = new DataTable();
            // Fill the DataTable
            dataAdapter.Fill(dataTable);
            // Bind the DataTable to the DataGridView
            emp_gridview.DataSource = dataTable;
            // Close the connection
            conn.Close();
        }
    }
}
