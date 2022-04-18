using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int passengers;
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                if (command.Length == 2)
                {
                    passengers = int.Parse(command[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    passengers = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
