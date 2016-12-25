using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;

namespace LinkedList
{
    public class Queue <T>: IQueue<T>
    {
        LinkedList<T> linkedList = new LinkedList<T>();

        public void Enqueue(T enqueue)
        {
            linkedList.AddHeadNode(enqueue);
        }

        public void Dequeue()
        {
            linkedList.GetNode(linkedList.Size);
            linkedList.RemoveTailNode();
        }

        public void PrintQueue()
        {
            linkedList.printNodes();
        }


    }
}
