using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditor.Model.Commands;

namespace TextEditor.Controller
{
    class CommandController
    {

        private CommandManager commandManager { get; set; }
        public string actualFile { get; set; }
        private int actualFileType { get; set; }
        private string actualText { get; set; }
        private bool saved { get; set; }

        public CommandController()
        {
            commandManager = new CommandManager();
            actualFile = "";
            actualFileType = 0;
            actualText = "";
            saved = false;
        }

        public bool IsSaved()
        {
            return saved;
        }

        public void useCommand(string commandStr, List<string> args)
        {
            ICommand command = commandManager.GetCommand(commandStr, args);
            command.execute();
        }

        public ICommand getCommand(string commandStr, List<string> args = null)
        {
            ICommand command = commandManager.GetCommand(commandStr, args);
            return command;
        }

        public void NewCommand()
        {
            actualFile = "";
            actualFileType = 0;
            actualText = "";
        }

        public void SaveCommand(RichTextBox rtb)
        {
            if (!(actualFile == ""))
            {
                List<string> args = new List<string>() {rtb.Rtf, actualFile, actualFileType.ToString() };
                Save command = (Save) getCommand("save", args);
                command.execute();
            }
        }

        public void SaveAsCommand(RichTextBox rtb, string fileName, int filterIndex)
        {
            List<string> args = new List<string>() { rtb.Rtf, fileName, filterIndex.ToString() };
            SaveAs command = (SaveAs) getCommand("saveas", args);
            command.execute();
            saved = true;
            actualFile = fileName;
            actualFileType = filterIndex;
        }

        public string OpenCommand(string fileName, int filterIndex)
        {
            saved = true;
            actualFile = fileName;
            actualFileType = filterIndex;
            List<string> args = new List<string>() { fileName, filterIndex.ToString() };
            Open command = (Open) getCommand("open", args);
            string text = command.getText();
            return text;
        }

        public void CopyCommand(string selectedText)
        {
            List<string> args = new List<string>() { selectedText };
            Copy commnad = (Copy) getCommand("copy", args);
            actualText = selectedText;
        }

        public string PasteCommand()
        {
            Paste command = (Paste) getCommand("paste");
            return actualText;
        }

        public void CutCommand(string selectedText)
        {
            List<string> args = new List<string>() { selectedText };
            Cut commnad = (Cut)getCommand("cut", args);
            actualText = selectedText;
        }

        public string RedoCommand()
        {
            Redo command = (Redo)  getCommand("redo");
            string text = command.redo();
            return text;
        }

        public string UndoCommand()
        {
            Undo command = (Undo) getCommand("undo");
            string text = command.undo();
            return text;
        }

        public void setState(string text)
        {
            commandManager.SetState(text);
        }

    }
}
