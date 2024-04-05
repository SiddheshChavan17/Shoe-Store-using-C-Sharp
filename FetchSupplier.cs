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
    public partial class FetchSupplier : Form
    {
        public FetchSupplier()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection();
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.Show();
            this.Close();
        }

        private void Sup_add_show_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
            this.Close();
        }

        private void Sup_upd_show_Click(object sender, EventArgs e)
        {
            UpdateSupplier updater = new UpdateSupplier();
            updater.Show();
            this.Close();
        }

        private void Suplogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FetchSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supplierDBDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.supplierDBDataSet.supplier);

            // TODO: This line of code loads data into the 'medDatabaseDataSet.SupplierTB' table. You can move, or remove it, as needed.
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\SupplierDB.accdb";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            // Assuming you have a table named 'YourTableName'
            string selectQuery = "SELECT * FROM supplier";
            // Create a data adapter
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectQuery, conn);
            // Create a DataTable to hold the results
            DataTable dataTable = new DataTable();
            // Fill the DataTable
            dataAdapter.Fill(dataTable);
            // Bind the DataTable to the DataGridView
            sup_gridview.DataSource = dataTable;
            // Close the connection
            conn.Close();
        }
    }
}
