using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int element = int.Parse(command[1]);
                    elements = AddElement(elements, element);
                }
                else if (command[0] == "Remove")
                {
                    int element = int.Parse(command[1]);
                    elements = RemoveElement(elements , element);
                }
                else if (command[0] == "RemoveAt")
                {
                    int removeIndex = int.Parse(command[1]);
                    elements = Removeindex(elements, removeIndex);
                }
                else
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    elements = InsertNumberInIndex(elements, number, index);
                }

                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine(string.Join(' ', elements));
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
