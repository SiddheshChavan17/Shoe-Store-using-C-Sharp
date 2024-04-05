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
    public partial class FetchProduct : Form
    {
        public FetchProduct()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection();
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
            this.Close();
        }

        private void Prologout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pro_upd_show_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.Show();
            this.Close();
        }

        private void Pro_add_show_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void FetchProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.product);

            // TODO: This line of code loads data into the 'medDatabaseDataSet.SupplierTB' table. You can move, or remove it, as needed.
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\ProductDB.accdb";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            // Assuming you have a table named 'YourTableName'
            string selectQuery = "SELECT * FROM product";
            // Create a data adapter
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectQuery, conn);
            // Create a DataTable to hold the results
            DataTable dataTable = new DataTable();
            // Fill the DataTable
            dataAdapter.Fill(dataTable);
            // Bind the DataTable to the DataGridView
            pro_gridview.DataSource = dataTable;
            // Close the connection
            conn.Close();
        }

        private void Pro_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
