using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers = numbers.OrderByDescending(n => n).ToList();

            if (numbers.Count < 3)
            {
                Console.WriteLine($"{string.Join(" ", numbers)}");
            }
            else
            {
                Console.WriteLine($"{string.Join(" ", numbers.Take(3))}");
            }

        }
    }

}


