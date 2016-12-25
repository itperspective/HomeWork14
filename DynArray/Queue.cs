using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;

namespace DynArray
{
    public class Queue <T>:IQueue<T>
    {
        DynamicArray<T> dynamicArray = new DynamicArray<T>();

        public void Enqueue(T enqueue)
        {
            dynamicArray.Add(enqueue);
        }

        public void Dequeue()
        {
            dynamicArray.Get(0);
            dynamicArray.Remove(0);
        }

        public void Print()
        {
            dynamicArray.Print();
        }

    }
}
