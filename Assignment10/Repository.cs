using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class Repository<T> where T :BaseEntity , IAuditable , new()
    {

        public T Create()
        {
            return new T();
        }

    }

}
