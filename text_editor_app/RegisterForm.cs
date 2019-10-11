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
            backToLoginForm();
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
                backToLoginForm();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Please fill all the fields to create an account.",
                    "Account Creation Failed",
                    MessageBoxButtons.RetryCancel
                    );
                if (dialogResult == DialogResult.Cancel)
                    backToLoginForm();
            }
                
        }

        private void backToLoginForm()
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
                StreamWriter sw;
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    _ = File.CreateText(path);
                }

                bool addNewLine = true;
                using (FileStream fs = new FileStream(path, FileMode.Open))
                using (BinaryReader rd = new BinaryReader(fs))
                {
                    fs.Position = fs.Length - 1;
                    int last = rd.Read();

                    // The last byte is 10 if there is a LineFeed 
                    if (last == 10)
                        addNewLine = false;
                }
                string allLines = (addNewLine ? Environment.NewLine + details : details);

                using (sw = File.AppendText(path))
                {
                    sw.WriteLine(allLines);
                }

                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
}
