using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            
            int limit = numbers.Count;

            for (int i = 0; i < limit; i++)
            {
                if (i + 1 >= numbers.Count)
                {
                    break;
                }

                double currentNum = numbers[i];
                double nextNumber = numbers[i + 1];
                if (currentNum == nextNumber)
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
