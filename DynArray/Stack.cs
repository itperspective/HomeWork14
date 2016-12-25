﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;

namespace DynArray
{
    public class Stack<T> : IStack<T>
    {

        DynamicArray<T> dynamicArray = new DynamicArray<T>();

      

        public T Peek()
        {

            return dynamicArray.Get(dynamicArray.Top - 1);
        }

        public T Pop()
        {
            T a = dynamicArray.Get(dynamicArray.Top-1);
            dynamicArray.Remove(dynamicArray.Top - 1);
            return a;
         }

        public void Push(T push)
        {
            dynamicArray.Add(push);
        }

        public void Print()
        {
            dynamicArray.Print();
        }



    }
}
