using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalShoeStore
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string username = Username_text.Text;
            string password = Password_text.Text;

            // Replace this with your authentication logic (e.g., database check)
            if (IsValidUser(username, password))
            {
                Mainscreen mainScreen = new Mainscreen();
                mainScreen.Show();
                this.Hide(); //hide the login form
                // You can open a new form or perform other actions here.
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        // Replace this method with your actual authentication logic
        private static bool IsValidUser(string username, string password)
        {
            // You should check the username and password against your database or authentication system here.
            // For this example, let's assume a hardcoded username and password.
            string validUsername = "admin";
            string validPassword = "admin";

            return (username == validUsername && password == validPassword);
        }
    }
 }

