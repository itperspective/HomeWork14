using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;
using DynArray;
using LinkedList;
using System.Diagnostics;

namespace HomeWork14
{
    public class TestPerformance
    {
        public int NumberIteractions { get; set; } 






        MyStack<int> stackArray;
        MyQueue<int> queueArray;
        DynArray.Stack<int> stackDynArray;
        DynArray.Queue<int> queueDynArray;
        LinkedList.Stack<int> stackLinkedList;
        LinkedList.Queue<int> queueLinkedList;

        Stopwatch watch = new Stopwatch();


        protected void ArrayInit(int size)
        {
            stackArray = new MyStack<int>(new int[size]);
            queueArray = new MyQueue<int>(new int[size]);
        }


        public void PopulateStack( IStack<int> stack)
        {
            for (int i=0; i< NumberIteractions+1; i++ )
            {
                stack.Push(i);
            }

        }
        public void PopulateQueue(IQueue<int> queue)
        {
            for(int i=0; i<NumberIteractions+1; i++)
            {
                queue.Enqueue(i);
            }
        }

        public void MeasureTime(IStack<int> stack, IQueue<int> queue, ref string stackTime, ref string queueTime)
        { 
            watch.Start();
            PopulateQueue(queue);
            watch.Stop();
            queueTime = String.Format("{0} ms", watch.ElapsedMilliseconds);
            watch.Reset();

            watch.Start();
            PopulateStack(stack);
            watch.Stop();
            stackTime = String.Format("{0} ms", watch.ElapsedMilliseconds);
            watch.Reset();

        }

        public void MeasureTime(ref string stackTime, ref string queueTime)
        {
            watch.Start();
            System.Collections.Generic.Queue<int> a = new System.Collections.Generic.Queue<int>();
            for (int i = 0; i < NumberIteractions; i++)
            {
                a.Enqueue(i);
            }
            watch.Stop();
            queueTime = String.Format("{0} ms", watch.ElapsedMilliseconds);
            watch.Reset();

            watch.Start();
            System.Collections.Generic.Stack<int> b = new System.Collections.Generic.Stack<int>();
            for (int i = 0; i < NumberIteractions; i++)
            {
                b.Push(i);
            }
            watch.Stop();
            stackTime = String.Format("{0} ms", watch.ElapsedMilliseconds);
            watch.Reset();

        }

    }
}
