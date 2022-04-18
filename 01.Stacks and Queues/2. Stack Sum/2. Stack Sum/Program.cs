using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(startNumbers);

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] splittedCommand = command.Split(' ').ToArray();

                if (splittedCommand[0] == "add")
                {
                    int firstNumber = int.Parse(splittedCommand[1]);
                    int secondNumber = int.Parse(splittedCommand[2]);
                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }
                else if (splittedCommand[0] == "remove")
                {
                    int count = int.Parse(splittedCommand[1]);
                    if (!(count > numbers.Count))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
