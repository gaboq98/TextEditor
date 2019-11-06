using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model.Memento
{
    class Caretaker
    {
        private List<Memento> mementoList = new List<Memento>();

        private int currentIndex;

        public Caretaker()
        {
            currentIndex = 0;
        }

        public void add(Memento state)
        {
            mementoList.Add(state);
            currentIndex++;
        }

        public Memento get(int index)
        {
            if(!(index < mementoList.Count))
            {
                return mementoList.ElementAt(index);
            }
            return getCurrent();
        }

        public Memento getCurrent()
        {
            return mementoList.ElementAt(currentIndex);
        }

        public Memento getPrevious()
        {
            int index = currentIndex - 1;
            if (!(index < 0))
            {
                currentIndex = index;
                return mementoList.ElementAt(currentIndex);
            }
            return getCurrent();
        }

        public Memento getNext()
        {
            int index = currentIndex + 1;
            if (!(index >= mementoList.Count))
            {
                currentIndex = index;
                return mementoList.ElementAt(currentIndex);
            }
            return getCurrent();
        }

    }
}
