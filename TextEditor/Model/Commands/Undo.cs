using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Model.Memento;

namespace TextEditor.Model.Commands
{
    class Undo : ICommand
    {
        private List<string> commandArgs;
        private Caretaker caretaker { get; set; }
        private Originator originator { get; set; }

        public Undo(List<string> commandArgs, Caretaker caretaker, Originator originator)
        {
            this.commandArgs = commandArgs;
            this.caretaker = caretaker;
            this.originator = originator;
        }

        public void execute()
        {
            originator.getStateFromMemento(caretaker.getPrevious());
        }

        public string undo()
        {
            originator.getStateFromMemento(caretaker.getPrevious());
            return originator.getState();
        }
    }
}
