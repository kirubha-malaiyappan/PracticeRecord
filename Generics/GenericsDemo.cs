using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Generics
{
    internal class GenericsDemo
    {
        internal T Add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2;
        }
        internal T Sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2;
        }
    }
}
