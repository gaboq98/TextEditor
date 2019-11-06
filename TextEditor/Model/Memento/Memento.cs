using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.Memento
{
    class Memento
    {
        private String state;

        public Memento(string state)
        {
            this.state = state;
        }

        public String getState()
        {
            return state;
        }
    }
}
