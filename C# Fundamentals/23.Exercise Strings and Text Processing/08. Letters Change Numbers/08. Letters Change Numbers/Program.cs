using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1];
                double number = double.Parse(item[1..^1].ToString());

                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    number /= position;
                }
                else
                {
                    int position = firstLetter - 96;
                    number *= position;
                }

                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    number -= position;
                }
                else
                {
                    int position = lastLetter - 96;
                    number += position;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
