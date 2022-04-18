using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = Enumerable.Range(1, n).ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var number in dividers)
            {
                predicates.Add(x => x % number == 0);
            }

            foreach (var num in numbers)
            {
                bool isDiv = true;
                foreach (var item in predicates)
                {
                    if (!item(num))
                    {
                        isDiv = false;
                        break;
                    }
                }
                if (isDiv) Console.Write(num + " ");
            }
        }
    }
}


