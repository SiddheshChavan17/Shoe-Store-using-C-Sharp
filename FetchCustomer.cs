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
    public partial class FetchCustomer : Form
    {
        public FetchCustomer()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection();

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FetchCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDBDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDBDataSet.customer);

            // TODO: This line of code loads data into the 'medDatabaseDataSet.SupplierTB' table. You can move, or remove it, as needed.
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\CustomerDB.accdb";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            // Assuming you have a table named 'YourTableName'
            string selectQuery = "SELECT * FROM customer";
            // Create a data adapter
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectQuery, conn);
            // Create a DataTable to hold the results
            DataTable dataTable = new DataTable();
            // Fill the DataTable
            dataAdapter.Fill(dataTable);
            // Bind the DataTable to the DataGridView
            cus_gridview.DataSource = dataTable;
            // Close the connection
            conn.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.Show();
            this.Close();
        }

        private void Cus_add_show_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Close();
        }

        private void Cus_upd_show_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer=new UpdateCustomer();
            updateCustomer.Show();
            this.Close();
        }
   
    }

}

