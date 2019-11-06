using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Model.FileManager;

namespace TextEditor.Model.Commands
{
    class SaveAs : ICommand
    {
        private List<string> commandArgs;

        public SaveAs(List<string> commandArgs, FilesManager fileManager)
        {
            this.commandArgs = commandArgs;
        }

        public void execute()
        {
            throw new NotImplementedException();
        }
    }
}
