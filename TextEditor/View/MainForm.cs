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
using TextEditor.Model.Commands;

namespace TextEditor
{
    public partial class MainForm : Form
    {

        private CommandController controller { get; set; }

        public MainForm()
        {
            InitializeComponent();
            controller = new CommandController();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unsaved chages will be disarted");
            controller.NewCommand();
            richTextBox.Clear();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unsaved chages will be disarted");
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = controller.OpenCommand(openFileDialog1.FileName, openFileDialog1.FilterIndex);
                richTextBox.Text = text;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            controller.SaveCommand();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                controller.OpenCommand(saveFileDialog1.FileName, saveFileDialog1.FilterIndex);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            controller.CopyCommand(richTextBox.SelectedText);
            richTextBox.Copy();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            controller.CutCommand(richTextBox.SelectedText);
            richTextBox.Cut();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            string text = controller.PasteCommand();
            richTextBox.Paste();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            string text = controller.UndoCommand();
            richTextBox.Text = text;
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            string text = controller.RedoCommand();
            richTextBox.Text = text;
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
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

        private void textChangeEvent(object sender, EventArgs e)
        {
            string text = richTextBox.Text;
            
            if(text.ElementAt(text.Length - 1) == ' ')
            {
                Console.WriteLine("###########################");
                controller.setState(richTextBox.Text);
            }
            
        }

    }
}
