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
            currentIndex = -1;
        }

        public void add(Memento state)
        {
            mementoList.Add(state);
            currentIndex = mementoList.Count - 1;
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

        public void clear()
        {
            List<Memento> newList = new List<Memento>();
            for(int i = 0; i < currentIndex; i++)
            {
                newList.Add(mementoList.ElementAt(i));
            }
            mementoList = newList;
        }


    }
}
