using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator<T>
    {
        public static T[] Create(int lenght, T item)
        {
            T[] array = new T[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}
