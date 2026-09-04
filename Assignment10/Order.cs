using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class Order:BaseEntity ,IAuditable
    {
        public void audit()
        {
            Console.WriteLine("Order audit");
        }
        public Order() { }
    }
}
