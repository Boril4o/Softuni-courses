using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Box<T>
    {
        public List<T> items = new List<T>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString();
        }

        public void Swap(int index1, int index2)
        {
            (items[index1], items[index2]) = (items[index2], items[index1]);
        }
    }
}
