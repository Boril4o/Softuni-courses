using System;
using System.Linq;
namespace _5._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int evenNumberSum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumberSum += item; 
                }
            }
            Console.WriteLine(evenNumberSum);
        }
    }
}
