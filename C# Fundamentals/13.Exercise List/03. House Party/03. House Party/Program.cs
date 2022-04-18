using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            string[] command = new string[4];
            string name;
            for (int i = 0; i < numOfCommands; i++)
            {
                command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command.Length == 4)
                {
                    name = command[0];
                    bool isPersonInTheList = guests.Contains(name);
                    if (isPersonInTheList)
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    name = command[0];
                    bool isPersonInTheList = guests.Contains(name);
                    if (!isPersonInTheList)
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join('\n', guests));
        }
    }
}
