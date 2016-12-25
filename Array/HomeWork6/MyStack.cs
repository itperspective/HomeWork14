using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MyStack<T> : Buffer<T>, IStack<T>
    {
        public MyStack(T[] Array) : base(Array)
        {

        }
        public override bool IsEmpty()
        {
            if (top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool IsFull()
        {
            if (top == array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Peek()
        {
            return array[top];
        }

        public T Pop()
        {

            Console.WriteLine("Pop from stack:");
            top = top - 1;
            return array[top];


        }

        public void Push(T push)
        {
            if (top < array.Length)
            {
                array[top] = push;
                top = top + 1;
            }

           
        }



    }

}

