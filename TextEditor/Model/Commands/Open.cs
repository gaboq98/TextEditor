using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Model.FileManager;

namespace TextEditor.Model.Commands
{
    class Open : ICommand
    {
        private List<string> commandArgs;

        public Open(List<string> commandArgs, FilesManager fileManager)
        {
            this.commandArgs = commandArgs;
        }

        public void execute()
        {
            throw new NotImplementedException();
        }

        public string getText()
        {
            return commandArgs.ElementAt(0);
        }
    }
}
