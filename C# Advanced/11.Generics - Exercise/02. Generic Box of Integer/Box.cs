using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> items = new Stack<T>();

        public int Count => items.Count;

        public void Add(T item)
        {
            items.Push(item);
        }

        public T Remove()
        {
            return items.Pop();
        }
    }
}
