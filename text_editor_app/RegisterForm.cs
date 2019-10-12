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
    public partial class RegisterForm : Form
    {
        private static readonly string projectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        public RegisterForm()
        {
            InitializeComponent();
            foreach (string type in Enum.GetNames(typeof(User.UserType)))
                UserTypeComboBox.Items.Add(type);
            DobDatePicker.Format = DateTimePickerFormat.Custom;
            DobDatePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void CancelAccountCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackToLoginScreen();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string[] userDetails = new string[] {
                UsernameField.Text,
                PasswordField.Text,
                UserTypeComboBox.Text,
                FNameField.Text, LNameField.Text,
                DobDatePicker.Value.ToString("dd-MM-yyyy")
            };
            string joinedString = string.Join(",", userDetails);
            if (AddUserToLoginFile(joinedString))
            {
                MessageBox.Show(
                    "User has been successfully added! You may now login using your new details.",
                    "User Added Successfully",
                    MessageBoxButtons.OK
                    );
                BackToLoginScreen();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Please fill all the fields to create an account.",
                    "Account Creation Failed",
                    MessageBoxButtons.RetryCancel
                    );
                if (dialogResult == DialogResult.Cancel)
                    BackToLoginScreen();
            }
                
        }

        private void BackToLoginScreen()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private bool AddUserToLoginFile(string details)
        {
            string path = Path.Combine(projectDir, "login.txt");
            
            try
            {
                StreamWriter streamWriter;
                if (!File.Exists(path))
                {
                    _ = File.CreateText(path);
                }

                bool addNewLine = true;
                using (FileStream fileStream = new FileStream(path, FileMode.Open))
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    fileStream.Position = fileStream.Length - 1;
                    int last = binaryReader.Read();

                    // The last byte is 10 if there is a LineFeed 
                    if (last == 10)
                        addNewLine = false;
                }
                string allLines = (addNewLine ? Environment.NewLine + details : details);

                using (streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine(allLines);
                }
                
                streamWriter.Close();

                UserList.AddUser(details);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToLoginScreen();
        }
    }
}
