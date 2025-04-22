using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234") // simple check
            {
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
                this.Hide(); // hide login form
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
