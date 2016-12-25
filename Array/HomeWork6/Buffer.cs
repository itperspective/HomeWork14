using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Buffer<T>
    {
        protected T[] array;
        protected int top;
        protected int count;
        protected int head;
        protected int tail;

        public Buffer(T[] Array)
        {
            this.array = Array;
            this.top = 0;
            this.count = 0;
            this.head = 0;
            this.tail = 0;
        }
        
        public virtual bool IsEmpty()
        {
            return true;
        }

        public virtual bool IsFull()
        {
            return true;
        }

        public virtual void Print()
        {

        }

        


    }
}
