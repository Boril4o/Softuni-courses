using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int limit = numbers.Count / 2;

            for (int i = 0; i < limit; i++)
            {
                int currentElement = numbers[i];
                int lastElement = numbers[numbers.Count - 1];
                numbers[i] += lastElement;
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
