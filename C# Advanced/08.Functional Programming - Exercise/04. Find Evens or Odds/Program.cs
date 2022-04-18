using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>(range[1] - range[0]);
            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            string evenOrOdd = Console.ReadLine();

            if (evenOrOdd == "even")
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }
            else
            {
                numbers = numbers.Where(x => !isEven(x)).ToList();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }

}


