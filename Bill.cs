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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalShoeStore
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\siddh\OneDrive\Documents\CustomerDB.accdb"))
            {
                connection.Open();

                string query = "SELECT Customer_Name, Contact_Number, [E-Mail], Address FROM customer WHERE Customer_ID = ?";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", Cust_id.Text);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["Customer_Name"].ToString();
                            textBox3.Text = reader["Contact_Number"].ToString();
                            textBox4.Text = reader["E-Mail"].ToString();
                            textBox2.Text = reader["Address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer Not found.");
                        }
                    }
                }
            }

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            this.Close();
        }
    }
}
