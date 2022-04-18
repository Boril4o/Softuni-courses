using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            int countOfPassedCars = 0;

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        countOfPassedCars++;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{countOfPassedCars} cars passed the crossroads.");
        }
    }
}
