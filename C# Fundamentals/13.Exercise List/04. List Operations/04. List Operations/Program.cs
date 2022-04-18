using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] lines = command.Split();
                if (lines[0] == "Add")
                {
                    int numToAdd = int.Parse(lines[1]);
                    numbers.Add(numToAdd);
                }
                else if (lines[0] == "Insert")
                {
                    int numToInsert = int.Parse(lines[1]);
                    int insertIndex = int.Parse(lines[2]);
                    if (insertIndex >= 0 && insertIndex < numbers.Count)
                    {
                        numbers.Insert(insertIndex, numToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (lines[0] == "Remove")
                {
                    int indexToRemove = int.Parse(lines[1]);
                    if (indexToRemove < 0 || indexToRemove > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.RemoveAt(indexToRemove);
                    }
                }
                else if (lines[0] == "Shift")
                {
                    if (lines[1] == "left")
                    {
                        int rotations = int.Parse(lines[2]);
                        for (int i = 0; i < rotations; i++)                 //// РОТАЦИЯ НА ЧИСЛАТА ,НАЙ-ЛЯВОТО СТАВА ПОСЛЕДНО И Т.Н. В ЗАВИСИМОСТ
                        {                                                      /////От РОТАЦИИТЕ
                            int firstNum = numbers[0];
                            numbers.Add(firstNum);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (lines[1] == "right")                               //// РОТАЦИЯ НА ЧИСЛАТА ,НАЙ-КРАЙНОТО СТАВА ПЪРВО И Т.Н. В ЗАВИСИМОСТ
                    {                                                        /////От РОТАЦИИТЕ
                        int rotations = int.Parse(lines[2]);
                        for (int i = 0; i < rotations; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNum);
                            numbers.RemoveAt(numbers.Count - 1);
                        }

                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
