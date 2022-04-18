using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop") break;
                int value = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                {
                    resources[input] += value;
                }
                else
                {
                    resources.Add(input, value);
                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
