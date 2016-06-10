using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Part2
{
    interface IMyQueue<T> : IBuffer<T>
    {
        void Enqueue(T addValueToQueue);
        T Dequeue();
    }
}
