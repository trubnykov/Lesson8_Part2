using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Part2
{
    public abstract class Buffer<T> : IBuffer<T>
    {
        protected T[] array = new T[5];
        public abstract void IsEmpty();
        public abstract void IsFull();
        public abstract void Peek();

        public void Print(T[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
            {
                Console.WriteLine(arrayToPrint[i]);
            }
        }

    }
}
