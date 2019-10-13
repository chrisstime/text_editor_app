using System;
using System.Windows.Forms;

namespace text_editor_app
{
    // Class for the login form
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Get user with matching username and password from list of users (if there are any).
            User user = UserList.GetUser(UserNameInput.Text, PasswordInput.Text);
            
            // Show the word form if a matching user is found, othrewise show error message.
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
            // Create a now register form and show it. Subsequently, hid this login form.
            Form registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit program on login form close.
            Application.Exit();
        }
    }
}
