using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Code for Login Window

namespace _14022469Assignment2
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            UserName.AutoSize = false;
            UserName.Size = new Size(200, 29);
            UserPassword.AutoSize = false;
            UserPassword.Size = new Size(200, 29);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            new NewUserWindow(this).Show();
        }

        private void SignUpButton_MouseEnter(object sender, EventArgs e)
        {
            SignUpButton.FlatAppearance.BorderSize = 3;
        }

        private void SignUpButton_MouseLeave(object sender, EventArgs e)
        {
            SignUpButton.FlatAppearance.BorderSize = 2;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.FlatAppearance.BorderSize = 3;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.FlatAppearance.BorderSize = 2;
        }

        

        private void lockIcon_Click(object sender, EventArgs e)
        {

        }

        private void userIcon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // User Login Functionality 
        //reads the user name and password from the login window and verify it with "login.txt" file

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool loginSuccessful = false;
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users)
            {
                string[] separator = { ",", " " };
                string[] userInfo = user.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (UserName.Text == userInfo[0] && UserPassword.Text == userInfo[1])
                {

                    loginSuccessful = true;
                    Hide();
                    new MainWindow2(this, $"{userInfo[3]} {userInfo[4]}", userInfo[2]).Show();
                    break;
                }
            }
            if (!loginSuccessful)
                MessageBox.Show("Incorrect username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            UserPassword.Text = string.Empty;
            
        }
    }
}
