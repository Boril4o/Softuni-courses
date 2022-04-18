using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            Queue<int> nums = new Queue<int>(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = nums.Dequeue();
                if (currNumber % 2 == 0)
                {
                    nums.Enqueue(currNumber);
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
