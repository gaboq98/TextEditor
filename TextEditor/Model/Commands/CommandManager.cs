using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.Commands
{
    class CommandManager
    {
        private ICommand Command { get; set; }

        public void ActionCommand()
        {
            Command.execute();
        }

        public ICommand GetCommand(String commandStr)
        {
            ICommand command;
            switch (commandStr)
            {
                case "copy":
                    Console.WriteLine("Case 1");
                    command = new Copy();
                    break;
                case "cut":
                    Console.WriteLine("Case 2");
                    command = new Cut();
                    break;
                case "new":
                    Console.WriteLine("Case 3");
                    command = new New();
                    break;
                case "open":
                    Console.WriteLine("Case 4");
                    command = new Open();
                    break;
                case "paste":
                    Console.WriteLine("Case 5");
                    command = new Paste();
                    break;
                case "redo":
                    Console.WriteLine("Case 6");
                    command = new Redo();
                    break;
                case "save":
                    Console.WriteLine("Case 7");
                    command = new Save();
                    break;
                case "saveas":
                    Console.WriteLine("Case 8");
                    command = new SaveAs();
                    break;
                case "undo":
                    Console.WriteLine("Case 9");
                    command = new Undo();
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
