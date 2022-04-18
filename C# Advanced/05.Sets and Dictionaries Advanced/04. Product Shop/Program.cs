using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Dictionary<string, double>>> shops = new SortedDictionary<string, List<Dictionary<string, double>>>();
            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] splittedCommand = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = splittedCommand[0];
                string product = splittedCommand[1];
                double price = double.Parse(splittedCommand[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new List<Dictionary<string, double>>());
                    shops[shop].Add(new Dictionary<string, double>());
                }

                shops[shop][0].Add(product, price);
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value[0])
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }

}


