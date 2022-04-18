using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> add = n => n + 1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> subtract = n => n - 1;
            Action<int[]> print = nums => Console.WriteLine(string.Join(" ", nums));

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(n => add(n)).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(n => multiply(n)).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(n => subtract(n)).ToArray();
                }
                else
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }

}


