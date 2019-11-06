using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Model.FileManager;
using TextEditor.Model.Memento;

namespace TextEditor.Model.Commands
{
    class CommandManager
    {
        private Caretaker caretaker { get; set; }
        private Originator originator { get; set; }
        private List<string> commandArgs { get; set; }
        private FilesManager fileManager { get; set; }

        public CommandManager()
        {
            commandArgs = new List<string>();
            caretaker = new Caretaker();
            originator = new Originator();
            fileManager = new FilesManager();
        }

        public Originator GetOriginator()
        {
            return originator;
        }

        public Caretaker GetCaretaker()
        {
            return caretaker;
        }

        public void SetState(string text)
        {
            originator.setState(text);
            caretaker.add( originator.saveStateToMemento());
            //caretaker.clear();
        }

        public ICommand GetCommand(String commandStr, List<string> args)
        {
            commandArgs = args;
            ICommand command;
            switch (commandStr)
            {
                case "copy":
                    Console.WriteLine("Case 1");
                    command = new Copy(commandArgs);
                    break;
                case "cut":
                    Console.WriteLine("Case 2");
                    command = new Cut(commandArgs);
                    break;
                case "new":
                    Console.WriteLine("Case 3");
                    command = new New(commandArgs);
                    break;
                case "open":
                    Console.WriteLine("Case 4");
                    command = new Open(commandArgs, fileManager);
                    break;
                case "paste":
                    Console.WriteLine("Case 5");
                    command = new Paste(commandArgs);
                    break;
                case "redo":
                    Console.WriteLine("Case 6");
                    command = new Redo(commandArgs, caretaker, originator);
                    break;
                case "save":
                    Console.WriteLine("Case 7");
                    command = new Save(commandArgs, fileManager);
                    break;
                case "saveas":
                    Console.WriteLine("Case 8");
                    command = new SaveAs(commandArgs, fileManager);
                    break;
                case "undo":
                    Console.WriteLine("Case 9");
                    command = new Undo(commandArgs, caretaker, originator);
                    break;
                default:
                    Console.WriteLine("Default case");
                    command = null;
                    break;
            }
            return command;
        }

    }
}
