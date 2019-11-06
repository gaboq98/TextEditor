using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Model.FileLoader;
using TextEditor.Model.FileManager;

namespace TextEditor.Model.Commands
{
    class Open : ICommand
    {
        private List<string> commandArgs;
        private string loadedTxt;
        private IFileLoader loader;

        public Open(List<string> commandArgs, FilesManager fileManager)
        {
            this.commandArgs = commandArgs;
        }

        public void execute()
        {
            System.Console.WriteLine(commandArgs.ElementAt(1));
            switch (commandArgs.ElementAt(1))
            {
                case "1":
                    this.loader = new TxtFileLoader();
                    this.loadedTxt = loader.load(commandArgs.ElementAt(0));
                    break;
                case "2":
                    this.loader = new TabFileLoader();
                    this.loadedTxt = loader.load(commandArgs.ElementAt(0));
                    break;
                case "3":
                    this.loader = new CsvFileLoader();
                    this.loadedTxt = loader.load(commandArgs.ElementAt(0));
                    break;
                case "4":
                    this.loader = new XmlFileLoader();
                    this.loadedTxt = loader.load(commandArgs.ElementAt(0));
                    break;
                default:
                    this.loader = new JsonFileLoader();
                    this.loadedTxt = loader.load(commandArgs.ElementAt(0));
                    break;

            }
        }

        public string getText()
        {
            execute();
            return loadedTxt;
        }
    }
}
