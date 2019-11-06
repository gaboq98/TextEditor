using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Model.FileManager;
using TextEditor.Model.FileSaver;

namespace TextEditor.Model.Commands
{
    class SaveAs : ICommand
    {
        private List<string> commandArgs;
        private IFileSaver saver;

        public SaveAs(List<string> commandArgs, FilesManager fileManager)
        {
            this.commandArgs = commandArgs;
        }

        public void execute()
        {
            System.Console.WriteLine(commandArgs.ElementAt(2));
            switch (commandArgs.ElementAt(2))
            {
                case "1":
                    saver = new TxtFileSaver();
                    saver.save(commandArgs.ElementAt(0), commandArgs.ElementAt(1));
                    break;
                case "2":
                    saver = new TabFileSaver();
                    saver.save(commandArgs.ElementAt(0), commandArgs.ElementAt(1));
                    break;
                case "3":
                    saver = new CsvFileSaver();
                    saver.save(commandArgs.ElementAt(0), commandArgs.ElementAt(1));
                    break;
                case "4":
                    saver = new PdfFileSaver();
                    saver.save(commandArgs.ElementAt(0), commandArgs.ElementAt(1));
                    break;
                case "5":
                    saver = new XmlFileSaver();
                    saver.save(commandArgs.ElementAt(0), commandArgs.ElementAt(1));
                    break;
                default:
                    saver = new JsonFileSaver();
                    saver.save(commandArgs.ElementAt(0), commandArgs.ElementAt(1));
                    break;

            }
        }
    }
}
