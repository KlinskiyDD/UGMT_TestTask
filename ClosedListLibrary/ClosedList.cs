using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosedListLibrary
{
    public class ClosedList<T> : Collection<T>, IClosedList<T>
    {
        private int currentIndex;

        public ClosedList() : base() { }

        void ThrowInvalidIfListIsEmpty()
        {
            if (Count == 0)
                throw new InvalidOperationException("List is Empty");
        }

        public T Head
        {
            get
            {
                ThrowInvalidIfListIsEmpty();
                return this[0];
            }
        }
  
        public T Current
        {
            get
            {
                ThrowInvalidIfListIsEmpty();
                return this[currentIndex];
            }
        }
   
        public T Previous
        {
            get
            {
                ThrowInvalidIfListIsEmpty();
                return currentIndex == 0 ? this[Count - 1] : this[currentIndex - 1];
            }
        }

        public T Next
        {
            get
            {
                ThrowInvalidIfListIsEmpty();
                return this[(currentIndex + 1) % Count];
            }
        }
        
        public void MoveBack(int step = 1)
        {
            ThrowInvalidIfListIsEmpty();
            currentIndex = currentIndex == 0 ? Count - step : currentIndex - step;
            HeadReached += ClosedList_HeadReached;
        }

        public void MoveNext(int step = 1)
        {
            ThrowInvalidIfListIsEmpty();
            currentIndex = (currentIndex + 1) % Count;
            HeadReached += ClosedList_HeadReached;
        }

        public event EventHandler<T> HeadReached = delegate { };

        private void ClosedList_HeadReached(object sender, T e)
        {
            if (currentIndex == 0)
            {
                HeadReached(sender, e);
            }
        }

    }
}
