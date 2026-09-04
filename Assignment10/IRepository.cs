using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal interface IRepository<T>
    {
        public void Add(T item);
        public T Get();
        List<T> GetAll();

    }
}
