using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.Memento
{
    class Originator
    {
        private String state;

        public void setState(String state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }

        public Memento saveStateToMemento()
        {
            return new Memento(state);
        }

        public void getStateFromMemento(Memento memento)
        {
            state = memento.getState();
        }
    }
}
