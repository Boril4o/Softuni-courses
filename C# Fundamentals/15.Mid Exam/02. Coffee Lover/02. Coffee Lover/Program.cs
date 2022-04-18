using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int numOfCommands = int.Parse(Console.ReadLine());

            for (int currCommand = 0; currCommand < numOfCommands; currCommand++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                if (command[0] == "Include")
                {
                    string coffeeName = command[1];
                    coffees.Add(coffeeName);
                }
                else if (command[0] == "Remove")
                {
                    string firstOrLast = command[1];
                    int numbersOfCoffees = int.Parse(command[2]);
                    if (numbersOfCoffees > coffees.Count - 1)
                    {
                        continue;
                    }
                    Remove(coffees, numbersOfCoffees, firstOrLast);
                }
                else if (command[0] == "Prefer")
                {
                    int coffeeIndex1 = int.Parse(command[1]);
                    int coffeeIndex2 = int.Parse(command[2]);
                    if (coffeeIndex1 > coffees.Count - 1 || coffeeIndex2 > coffees.Count - 1)
                    {
                        continue;
                    }
                    Prefer(coffees, coffeeIndex1, coffeeIndex2);
                }
                else
                {
                    coffees.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(' ', coffees));
        }

        static void Remove(List<string> coffees, int numOfCoffees, string firstOrlast)
        {
            if (firstOrlast == "first")
            {
                for (int i = 0; i < numOfCoffees; i++)
                {
                    coffees.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < numOfCoffees; i++)
                {
                    coffees.RemoveAt(coffees.Count - 1);
                }
            }
        }

        static void Prefer(List<string> coffees, int coffeeIndex1, int coffeeIndex2)
        {
            string firstCoffeName = coffees[coffeeIndex1];
            string secondCoffeeName = coffees[coffeeIndex2];
            coffees.Insert(coffeeIndex1, secondCoffeeName);
            coffees.RemoveAt(coffeeIndex1 + 1);
            coffees.Insert(coffeeIndex2, firstCoffeName);
            coffees.RemoveAt(coffeeIndex2 + 1);
        }
    }
}
