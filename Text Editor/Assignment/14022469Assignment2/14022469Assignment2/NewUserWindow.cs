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

namespace _14022469Assignment2
{
    public partial class NewUserWindow : Form
    {
        LoginWindow loginWindow;
        public NewUserWindow(LoginWindow loginWindow)
        {
            InitializeComponent();
            this.loginWindow = loginWindow;
        }


        private void NewUserWindow_Load(object sender, EventArgs e)
        {

        }

        private void FirstName_Enter(object sender, EventArgs e)
        {

        }

        private void FirstName_Leave(object sender, EventArgs e)
        {

        }

        private void LastName_Enter(object sender, EventArgs e)
        {

        }

        private void LastName_Leave(object sender, EventArgs e)
        {

        }

        private void UserName_Enter(object sender, EventArgs e)
        {

        }

        private void UserName_Leave(object sender, EventArgs e)
        {

        }

        private void Password_Enter(object sender, EventArgs e)
        {

        }

        private void Password_Leave(object sender, EventArgs e)
        {

        }

        private void CPassword_Enter(object sender, EventArgs e)
        {

        }

        private void CPassword_Leave(object sender, EventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                MessageBox.Show("First Name cannot be blank.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(LastName.Text == "")
            {
                MessageBox.Show("Last Name cannot be blank.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (UserName.Text == "")
            {
                MessageBox.Show("Username cannot be blank.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (UsernameExists(UserName.Text))
            {
                MessageBox.Show("Username already exists.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Password cannot be blank.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (CPassword.Text == "" || (Password.Text != CPassword.Text))
            {
                MessageBox.Show("Passwords do not match.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (UserType.SelectedItem == null)
            {
                MessageBox.Show("Please select user type.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                File.AppendAllText("login.txt", $"\n{UserName.Text},{Password.Text}," +
                    $"{UserType.SelectedItem},{FirstName.Text},{LastName.Text}," +
                    $"{DOB.Value.ToString("dd-MM-yyyy")}");
                MessageBox.Show("Account created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                loginWindow.Show();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            loginWindow.Show();
        }

        private void CancelBtn_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void CancelBtn_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private bool UsernameExists(string username)
        {
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users)
            {
                string[] separator = { ",", " " };
                string[] userInfo = user.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (username == userInfo[0])
                    return true;
            }
            return false;
        }

        

        private void CancelB_Click(object sender, EventArgs e)
        {
            Close();
            loginWindow.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
