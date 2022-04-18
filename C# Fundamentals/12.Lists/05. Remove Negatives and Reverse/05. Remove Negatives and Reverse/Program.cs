using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n >= 0)
                .Reverse()
                .ToList();

            if (nums.Count != 0)
            {
                Console.WriteLine(string.Join(' ', nums));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
