using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isCappitalLetter = x => char.IsUpper(x[0]);
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isCappitalLetter(x))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }

}


