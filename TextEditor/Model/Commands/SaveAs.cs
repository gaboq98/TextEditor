using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.Commands
{
    class SaveAs : ICommand
    {
        private List<string> commandArgs;

        public SaveAs(List<string> commandArgs)
        {
            this.commandArgs = commandArgs;
        }

        public void execute()
        {
            throw new NotImplementedException();
        }
    }
}
