using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor.Model.Memento
{
    class Caretaker
    {

        Stack<Memento> undoList = new Stack<Memento>();
        Stack<Memento> redoList = new Stack<Memento>();
        Memento lastUndo;
        Memento lastRedo;

        public Caretaker()
        {
        }

        public void add(Memento state)
        {
            undoList.Push(state);
        }

        public Memento getPrevious()
        {
            Memento aux;
            try
            {
                undoList.Pop();
                aux = undoList.Pop();
                redoList.Push(aux);
            } catch
            {
                MessageBox.Show("No more undo");
                aux = new Memento("") ;
            }
            
            return aux;
        }

        public Memento getNext()
        {
            Memento aux;
            try
            {
                redoList.Pop();
                aux = redoList.Pop();
                redoList.Push(aux);
            }
            catch
            {
                MessageBox.Show("No more Redo");
                aux = new Memento("");
            }

            return aux;
        }

    }
}
