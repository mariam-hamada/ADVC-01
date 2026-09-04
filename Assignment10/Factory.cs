using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class Factory<T> where T : new()
    {

        public T Create()
        {
            return new T();
        }

    }
}
