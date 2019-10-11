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

        public WordApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupRichTextbox();
            FontStyleComboBox.SelectedItem = richTextBox1.Font.Name;
            FontStyleComboBox.SelectedText = richTextBox1.Font.Name;
            FontSizeComboBox.SelectedItem = richTextBox1.Font.Size;
            FontSizeComboBox.SelectedText = richTextBox1.Font.Size.ToString();
            UserNameView.Text = String.Format("Username: {0}", User.UserName);

            int[] fontSizes = Enumerable.Range(8, 75).ToArray();
            foreach (int size in fontSizes)
                FontSizeComboBox.Items.Add(size.ToString());

            InstalledFontCollection availableFonts = new InstalledFontCollection();
            FontFamily[] fonts = availableFonts.Families.ToArray();
            foreach (FontFamily fontFam in fonts)
                FontStyleComboBox.Items.Add(fontFam.Name);
        }

        private void SetupRichTextbox()
        {
            richTextBox1.Font = new Font(this.Font.Name, 9, this.Font.Style);
            if (User.Type.Equals(User.UserType.View)) 
                richTextBox1.ReadOnly = true;
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
            {
                richTextBox1.Paste();
            }
        }

        private void BoldText(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void ItalicText(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void UnderlineText(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Filter = "All files (*.*)|*.*|RTF files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save File";

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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
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
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            if (openFile1.ShowDialog() == DialogResult.OK && openFile1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFile1.FileName);
                currentFilePath = Path.GetFullPath(openFile1.FileName);
            }
        }

        private void FontStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontStyleComboBox.Text, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            float.TryParse(FontSizeComboBox.Text, out float updatedFontSize);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, updatedFontSize, richTextBox1.SelectionFont.Style);
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }

        private void About(object sender, EventArgs e)
        {
            string version = System.Windows.Forms.Application.ProductVersion;
            MessageBox.Show(String.Format("Wripe Text Editor\nApp Version {0}", version), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Form newLogin = new LoginForm();
            newLogin.Show();
            Hide();
        }
    }
}
