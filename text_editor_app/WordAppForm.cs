using System;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Text;

namespace text_editor_app
{
    public partial class WordApp : Form
    {
        public WordApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void ItalicText(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void UnderlineText(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "All files (*.*)|*.*|RTF files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

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
            }
        }

        private void FontSizeComboBox_DropDown(object sender, EventArgs e)
        {
            int[] fontSizes = Enumerable.Range(8, 75).Where(x => x % 2 == 0).ToArray();
            foreach(int size in fontSizes)
                FontSizeComboBox.Items.Add(size);
        }

        private void FontStyleComboBox_DropDown(object sender, EventArgs e)
        {
            InstalledFontCollection availableFonts = new InstalledFontCollection();
            FontFamily[] fonts = availableFonts.Families.ToArray();
            foreach (FontFamily fontFam in fonts)
                FontStyleComboBox.Items.Add(fontFam.Name);
        }
    }
}
