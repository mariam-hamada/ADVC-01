using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class Box<T> where T : struct
    {
        public T Value  { get; set; }
        public Box (T value)
        {
            Value = value;
        }
    }
}
