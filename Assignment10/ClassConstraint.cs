using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class ClassConstraint <T> where T: class
    {
        public T Value { get; set; }
        public ClassConstraint (T value)
        {
            Value = value;
        }
    }
}
