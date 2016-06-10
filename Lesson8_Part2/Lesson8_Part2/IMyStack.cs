using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Part2
{
    interface IMyStack<T> : IBuffer<T>
    {
        void Push(T valueToPush);
        int Pop();
    }
}
