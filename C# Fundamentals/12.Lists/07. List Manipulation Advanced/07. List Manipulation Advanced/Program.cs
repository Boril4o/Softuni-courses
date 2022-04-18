using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = new string[3];
            command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            bool isChangesMadeOnElements = false;

            while (command[0] != "end")
            {
                if (command[0] == "Contains")
                {
                    int num = int.Parse(command[1]);
                    bool isContains = ContainsNumberChecker(elements, num);
                    if (isContains)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEvenNumbers(elements);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrindOddNumbers(elements);
                }
                else if (command[0] == "GetSum")
                {
                    int sum = GetSumOfDigits(elements);
                    Console.WriteLine(sum);
                }
                else if (command[0] == "Filter")
                {
                    string condition = command[1];
                    int num = int.Parse(command[2]);
                    PrintFilter(elements, condition, num);
                }
                else if (command[0] == "Add")
                {
                    int element = int.Parse(command[1]);
                    elements = AddElement(elements, element);
                    isChangesMadeOnElements = true;
                }
                else if (command[0] == "Remove")
                {
                    int element = int.Parse(command[1]);
                    elements = RemoveElement(elements, element);
                    isChangesMadeOnElements = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    int removeIndex = int.Parse(command[1]);
                    elements = Removeindex(elements, removeIndex);
                    isChangesMadeOnElements = true;
                }
                else
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    elements = InsertNumberInIndex(elements, number, index);
                    isChangesMadeOnElements = true;
                }

                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            if (isChangesMadeOnElements)
            {
                Console.WriteLine(string.Join(' ', elements));
            }
        }
        static bool ContainsNumberChecker(List<int> numbers, int num)
        {
            bool isContains = numbers.Contains(num);

            return isContains;
        }

        static void PrintEvenNumbers(List<int> nums)
        {
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"{num} ");
                }
            }

            Console.WriteLine();
        }

        static void PrindOddNumbers(List<int> nums)
        {
            foreach (int num in nums)
            {
                if (num % 2 != 0)
                {
                    Console.Write($"{num} ");
                }
            }

            Console.WriteLine();
        }

        static int GetSumOfDigits(List<int> nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }

            return sum;
        }

        static void PrintFilter(List<int> nums, string condition, int num)
        {
            if (condition == "<")
            {
                foreach (int num1 in nums)
                {
                    if (num1 < num)
                    {
                        Console.Write(num1 + " ");
                    }
                }
            }
            else if (condition == ">")
            {
                foreach (int num1 in nums)
                {
                    if (num1 > num)
                    {
                        Console.Write(num1 + " ");
                    }
                }
            }
            else if (condition == ">=")
            {
                foreach (int num1 in nums)
                {
                    if (num1 >= num)
                    {
                        Console.Write(num1 + " ");
                    }
                }
            }
            else
            {
                foreach (int num1 in nums)
                {
                    if (num1 <= num)
                    {
                        Console.Write(num1 + " ");
                    }
                }
            }

            Console.WriteLine();
        }

        static List<int> AddElement(List<int> elements, int element)
        {
            elements.Add(element);

            return elements;
        }

        static List<int> RemoveElement(List<int> elements, int elementToRemove)
        {
            elements.Remove(elementToRemove);

            return elements;
        }

        static List<int> Removeindex(List<int> elements, int removeIndex)
        {
            elements.RemoveAt(removeIndex);

            return elements;
        }

        static List<int> InsertNumberInIndex(List<int> elements, int number, int index)
        {
            elements.Insert(index, number);

            return elements;
        }
    }
}
