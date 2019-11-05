using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Controller;

namespace TextEditor
{
    public partial class MainForm : Form
    {

        private CommandController commandController { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.LoadFile(openFileDialog1.FileName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog1.Font;
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
