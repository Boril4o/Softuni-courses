using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                people.Add(name, age);
            }

            string condition = Console.ReadLine();
            int minAge = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (condition == "younger")
            {
                people = people.Where(x => x.Value < minAge).ToDictionary(x => x.Key, x => x.Value);
            }
            else
            {
                people = people.Where(x => x.Value >= minAge).ToDictionary(x => x.Key, x => x.Value);
            }

            if (format.Length == 2)
            {
                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
            else if (format[0] == "name")
            {
                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Key}");
                }
            }
            else
            {
                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Value}");
                }
            }
        }
    }

}


