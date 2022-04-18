using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = num => num % n == 0;
            numbers = numbers.Where(n => !isDivisible(n)).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}


