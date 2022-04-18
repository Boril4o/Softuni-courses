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
            Func<string[], string[]> nameFilter = names => names = names.Where(name => name.Length <= n).ToArray();
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join("\n", nameFilter(names)));
        }
    }
}


