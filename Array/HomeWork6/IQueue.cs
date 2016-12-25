﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public interface IQueue<T>
    {
        void Enqueue(T enqueue);

        void Dequeue();
    }
}
