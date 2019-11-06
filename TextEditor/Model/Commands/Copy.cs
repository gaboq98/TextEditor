using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.Commands
{
    class Copy : ICommand
    {
        private List<string> commandArgs;
        private string text;

        public Copy(List<string> commandArgs)
        {
            this.commandArgs = commandArgs;
        }

        public void execute()
        {
            text= commandArgs.ElementAt(0);
        }

        public string GetText()
        {
            return text;
        }
    }
}
