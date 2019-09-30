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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void BoldTextButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoldTextButton_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void ItalicsTextButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void UnderlineTextButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {

            if (richTextBox1.CanPaste(DataFormats.GetFormat(DataFormats.Rtf)))
            {
                richTextBox1.Paste();
            }
        }
    }
}
