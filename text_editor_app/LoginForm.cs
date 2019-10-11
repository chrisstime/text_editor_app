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
        private static readonly string projectDir = AppDomain.CurrentDomain.BaseDirectory;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Authenticate(UserNameInput.Text, PasswordInput.Text))
            {
                Form wordForm = new WordApp();
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

        private bool Authenticate(string userName, string passWord)
        {
            string[] fileContent = ReadFile("login.txt");
            bool allowAccess = false;
            char delimeterChar = ',';

            foreach (string line in fileContent)
            {
                string[] credentials = line.Split(delimeterChar);
                allowAccess = String.Equals(credentials[0], userName) && String.Equals(credentials[1], passWord);
                if (allowAccess)
                {
                    User.UserName = credentials[0];
                    User.Password = credentials[1];
                    User.Type = credentials[2].ToLower().Equals("view") ? User.UserType.View : User.UserType.Edit;
                    User.FName = credentials[3];
                    User.LName = credentials[4];
                    User.DOB = credentials[5];
                    break;
                }
            }

            return allowAccess;
        }

        private static string[] ReadFile(string textFile)
        {
            string[] fileContent = { };
            string textFilePath = Path.Combine(projectDir, textFile);
            try
            {
                if (File.Exists(textFilePath))
                    fileContent = File.ReadAllLines(textFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return fileContent;
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }
    }
}
