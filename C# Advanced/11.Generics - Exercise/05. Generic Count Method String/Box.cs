using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Box<T>
        where T : IComparable
    {
        public List<T> items = new List<T>();

        public int Compare(T Value)
        {
            int counter = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(Value) == 1)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
