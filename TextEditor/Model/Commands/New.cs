using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.Commands
{
    class New : ICommand
    {
        private List<string> commandArgs;

        public New(List<string> commandArgs)
        {
            this.commandArgs = commandArgs;
        }

        public void execute()
        {
            throw new NotImplementedException();
        }
    }
}
