﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Part2
{
    public interface IPrintable<T>
    {
        void Print(T[] arrayToPrint);
    }
}
