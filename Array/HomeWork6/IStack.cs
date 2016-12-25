using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public interface IStack<T>
    {

        T Peek();
        T Pop();
        void Push(T push);
    }
}
