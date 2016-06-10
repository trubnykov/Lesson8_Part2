using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Part2
{
    public interface IBuffer<T> : IPrintable<T>
    {
        void IsEmpty();
        void IsFull();
        void Peek();
    }
}
