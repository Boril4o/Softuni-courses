using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] splittedCommand = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (splittedCommand[0] == "IN")
                {
                    carNumbers.Add(splittedCommand[1]);
                }
                else if (splittedCommand[0] == "OUT")
                {
                    carNumbers.Remove(splittedCommand[1]);
                }
            }

            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var carNumber in carNumbers)
            {
                Console.WriteLine(carNumber);
            }
        }
    }

}


