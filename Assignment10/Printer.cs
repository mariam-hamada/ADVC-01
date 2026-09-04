using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class Printer<T> where T: Iprint 
    {
        public void print (T item)
        {
            item.print();
        }
    }
}
