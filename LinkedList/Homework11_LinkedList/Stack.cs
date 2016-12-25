using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;

namespace LinkedList
{
   public class Stack <T> : IStack<T>
    {
        LinkedList<T> linkedList = new LinkedList<T>();

        public void Push(T value)
        {
            linkedList.AddHeadNode(value);
        }

        public T Pop()
        {
            T temp;
           temp = linkedList.GetNode(0);
            linkedList.RemoveHeadNode();
            return temp;
        }

        public T Peek()
        {
            
           return linkedList.GetNode(0);
        }

        public void PrintStack()
        {
            linkedList.printNodes();
        }
    }
}
