using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class SafeList<T>
    {
        public static T Get ( int index , List<T> items )
        {
            if (index>=0 && index< items.Count)
            {
                return items[index];
            }
            return default ;
        }
    }
}
