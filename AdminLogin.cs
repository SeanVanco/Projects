using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AdminLogin : Form
    {
        string Username = "admin";
        string Password = "password";
        string usernameattempt;
        string passwordattempt;
        public AdminLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ActiveControl = usernameInput;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void nextToAdminAccess_Click(object sender, EventArgs e)
        {
            if ((usernameattempt == Username) && (passwordattempt == Password))
            {
                this.Hide();
                AdminAccess additionForm = new AdminAccess();
                additionForm.ShowDialog();
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }
        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            usernameattempt = usernameInput.Text;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            passwordattempt = passwordInput.Text;
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
