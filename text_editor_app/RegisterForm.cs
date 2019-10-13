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

            // Add the enum for user types.
            foreach (string type in Enum.GetNames(typeof(User.UserType)))
                UserTypeComboBox.Items.Add(type);

            // Set custom format and max date for the DOB date picker.
            DobDatePicker.Format = DateTimePickerFormat.Custom;
            DobDatePicker.CustomFormat = "dd-MM-yyyy";
            DobDatePicker.MaxDate = DateTime.Today;
        }

        private void CancelAccountCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackToLoginScreen();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            // Combine all the entered details into one line to be added to the login text file.
            string[] userDetails = new string[] {
                UsernameField.Text,
                PasswordField.Text,
                UserTypeComboBox.Text,
                FNameField.Text, LNameField.Text,
                DobDatePicker.Value.ToString("dd-MM-yyyy")
            };
            string joinedString = string.Join(",", userDetails);

            // Add user to the login file and show appropriate message box upon successful account creation.
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
            // Create a new login form and show. Subsequently hide this register form.
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private bool AddUserToLoginFile(string details)
        {
            string path = Path.Combine(projectDir, "login.txt");
            
            // Try to add user to login file.
            try
            {
                // Create a file if it doesn't exist.
                StreamWriter streamWriter;
                if (!File.Exists(path))
                {
                    _ = File.CreateText(path);
                }

                // Get the position of where the file ends.
                // See if we need to add a new line before writing to the file.
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
                // Add new line if needed.
                string allLines = (addNewLine ? Environment.NewLine + details : details);

                // Append the user details string to the file.
                using (streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine(allLines);
                }
                
                // Close the File Stream.
                streamWriter.Close();

                // Add the user to the Users List for this instance of the program
                // so we don't have to keep reading from the text file.
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
