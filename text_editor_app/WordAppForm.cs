using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Text;
using System.IO;

namespace text_editor_app
{
    public partial class WordApp : Form
    {
        private string currentFilePath;
        User currentUser;

        public WordApp(User user)
        {
            InitializeComponent();

            // Assign the current user for this word app as the person logged in.
            currentUser = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup rich text box attributes on form load.
            SetupRichTextbox();
            SetupFontStyle();
            SetupFontSize();
            // Show the user name of the current user logged in.
            UserNameView.Text = String.Format("Username: {0}", currentUser.UserName);
        }

        private void SetupRichTextbox()
        {
            richTextBox1.Font = new Font(this.Font.Name, 9, this.Font.Style);
            // Enable ctrl + c shortcuts etc (cut copy, paste, redo, undo) on the rich textbox.
            richTextBox1.ShortcutsEnabled = true;

            // Set the rich text box to read only if the user is only allowed to view.
            if (currentUser.CanEdit()) 
                richTextBox1.ReadOnly = true;
        }

        private void SetupFontStyle()
        {
            // Collect all the font families available on the device.
            InstalledFontCollection availableFonts = new InstalledFontCollection();
            FontFamily[] fonts = availableFonts.Families.ToArray();

            // Add font families available on the device on the font drop down.
            foreach (FontFamily fontFam in fonts)
                FontStyleComboBox.Items.Add(fontFam.Name);

            // Set the combox selected item to the current default on the rich text box.
            FontStyleComboBox.SelectedItem = richTextBox1.Font.Name;
            FontStyleComboBox.SelectedText = richTextBox1.Font.Name;
        }

        private void SetupFontSize()
        {
            // Add the font size range to the font size drop down.
            int[] fontSizes = Enumerable.Range(8, 75).ToArray();
            foreach (int size in fontSizes)
                FontSizeComboBox.Items.Add(size.ToString());

            // Set the current font size on the rich text box as the selected font size in the drop down.
            FontSizeComboBox.SelectedItem = richTextBox1.Font.Size;
            FontSizeComboBox.SelectedText = richTextBox1.Font.Size.ToString();
        }

        private void Cut(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Copy(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Paste(object sender, EventArgs e)
        {
            if (richTextBox1.CanPaste(DataFormats.GetFormat(DataFormats.Rtf)))
                richTextBox1.Paste();
        }

        private void BoldText(object sender, EventArgs e)
        {
            // If the user can edit and if there is selected text, apply bold to the selection font.
            if (richTextBox1.SelectionFont != null && currentUser.CanEdit() )
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void ItalicText(object sender, EventArgs e)
        {
            // If the user can edit and there is selected text, apply italic to the selection font.
            if (richTextBox1.SelectionFont != null && currentUser.CanEdit())
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void UnderlineText(object sender, EventArgs e)
        {
            // If the user can edit and if there is selected text, apply underline to the selection font.
            if (richTextBox1.SelectionFont != null && currentUser.CanEdit())
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            // Create a save file dialog.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // Ask the user if they're sure when they're about to overwrite a file.
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Filter = "All files (*.*)|*.*|RTF files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save File";

            // Automatically save the file and don't show the file dialog if the file already exists.
            // Otherwise show the save file dialog and ask the user where to save it and what to call it.
            if (!String.IsNullOrEmpty(currentFilePath))
            {
                try
                {
                    richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                catch
                {
                    MessageBox.Show("Could not save file. Please try again.", "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                currentFilePath = Path.GetFullPath(saveFileDialog1.FileName);
            }
        }

        private void SaveFileAs(object sender, EventArgs e)
        {
            // Create a save file dialog and promp the user what to call the file and where to save it.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // Ask the user if they're sure when they're about to overwrite a file.
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Filter = "All files (*.*)|*.*|RTF files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save File As";
            saveFileDialog1.FileName = Path.GetFileName(currentFilePath);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            // Create an open file dialog so the user can select a file to open.
            // Only allow rtf files to the opened.
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            if (openFile1.ShowDialog() == DialogResult.OK && openFile1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFile1.FileName);
                currentFilePath = Path.GetFullPath(openFile1.FileName);
            }
        }

        void WordApp_KeyDown(object sender, KeyEventArgs e)
        {
            // See if user press Ctrl + S, O or N key shortcuts
            // And call their matching commands.
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFile(sender, e);
                // Stop other controls from receiving the event.
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                OpenFile(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                NewWordWindow();
                e.SuppressKeyPress = true;
            }
        }

        private void FontStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Apply the font selected from the combo box to the selected font on the rich text box
            // if there is text selected and if user can edit
            if(richTextBox1.SelectionFont != null && currentUser.CanEdit())
                richTextBox1.SelectionFont = new Font(FontStyleComboBox.Text, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Apply the size selected from the combo box to the selected text size on the rich text box.
            // if there is text selected and if user can edit
            if (richTextBox1.SelectionFont != null && currentUser.CanEdit())
            {
                float.TryParse(FontSizeComboBox.Text, out float updatedFontSize);
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, updatedFontSize, richTextBox1.SelectionFont.Style);
            }
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            // Bring selected text to focus.
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }

        private void About(object sender, EventArgs e)
        {
            // Display the product name and version in the message box.
            string version = Application.ProductVersion;
            MessageBox.Show(
                String.Format("Wripe Text Editor\nApp Version {0}", version),
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // On logout button click close all the window app forms.
            Application.OpenForms.Cast<Form>().Where(x => (x is WordApp)).ToList().ForEach(x => x.Close());
        }

        private void BackToLoginScreen()
        {
            // Create a new login form and show it.
            Form newLogin = new LoginForm();
            newLogin.Show();
        }

        private void NewWordWindow_Click(object sender, EventArgs e)
        {
            NewWordWindow();
        }

        private void NewWordWindow()
        {
            // Create another word app screen using the same currentUser.
            Form anotherWordScreen = new WordApp(currentUser);
            anotherWordScreen.Show();
        }

        private void WordApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If all the Word app forms are closed, go back to the login screen.
            if (!(Application.OpenForms.Cast<Form>().Where(x => (x is WordApp)).Any()))
                BackToLoginScreen();
        }
    }
}
