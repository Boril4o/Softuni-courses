using System;
using System.Linq;
namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenNumbersSum += item;
                }
                else
                {
                    oddNumbersSum += item;
                }
            }

            Console.WriteLine($"{evenNumbersSum - oddNumbersSum}");
        }
    }
}
