using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Model.Memento;

namespace TextEditor.Model.Commands
{
    class Redo : ICommand
    {
        private List<string> commandArgs;
        private Caretaker caretaker { get; set; }
        private Originator originator { get; set; }

        public Redo(List<string> commandArgs, Caretaker caretaker, Originator originator)
        {
            this.commandArgs = commandArgs;
            this.caretaker = caretaker;
            this.originator = originator;
        }

        public void execute()
        {
            originator.getStateFromMemento(caretaker.getNext());
        }

        public string redo()
        {
            originator.getStateFromMemento(caretaker.getNext());
            return originator.getState();
        }

    }
}
