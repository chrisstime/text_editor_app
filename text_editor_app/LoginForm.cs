using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace text_editor_app
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = UserList.GetUser(UserNameInput.Text, PasswordInput.Text);
            if (user != null)
            {
                Form wordForm = new WordApp(user);
                wordForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(
                    "Username or password is incorrect. Please try again.", 
                    "Invalid Credentials", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
