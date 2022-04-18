using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            int index = numbers.Length;
            if (numbers.Length > 2)
            {
                index = 3;
            }

            for (int i = 0; i < index; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

        }
    }
}
