using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] array = ArrayCreator<int>.Create(5, 10);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}


