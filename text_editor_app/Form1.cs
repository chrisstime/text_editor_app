using System;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace text_editor_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
    }
}
