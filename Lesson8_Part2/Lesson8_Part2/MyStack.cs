using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Part2
{
    public class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        public override void IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override void IsFull()
        {
            throw new NotImplementedException();
        }

        public override void Peek()
        {
            throw new NotImplementedException();
        }
    }
}
