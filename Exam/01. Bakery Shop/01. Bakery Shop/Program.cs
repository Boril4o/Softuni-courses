using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<double> water = new Stack<double>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).Reverse());

            Stack<double> flour = new Stack<double>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));

            Dictionary<string, int> products = new Dictionary<string, int>();

            while (water.Count > 0 && flour.Count > 0)
            {
                double waterValue = water.Pop();
                double flourValue = flour.Pop();

                double waterPercentage = (waterValue * 100) / (waterValue + flourValue);
                double flourPercentage = 100 - waterPercentage;

                if (waterPercentage == 50 && flourPercentage == 50)
                {
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant", 0);
                    }

                    products["Croissant"]++;
                }
                else if (waterPercentage == 40 && flourPercentage == 60)
                {
                    if (!products.ContainsKey("Muffin"))
                    {
                        products.Add("Muffin", 0);
                    }

                    products["Muffin"]++;
                }
                else if (waterPercentage == 30 && flourPercentage == 70)
                {
                    if (!products.ContainsKey("Baguette"))
                    {
                        products.Add("Baguette", 0);
                    }

                    products["Baguette"]++;
                }
                else if (waterPercentage == 20 && flourPercentage == 80)
                {
                    if (!products.ContainsKey("Bagel"))
                    {
                        products.Add("Bagel", 0);
                    }

                    products["Bagel"]++;
                }
                else
                {
                    double leftFlour = Math.Abs(waterValue - flourValue);
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant", 0);
                    }

                    products["Croissant"]++;

                    List<double> newStack = flour.ToList();
                    newStack.Add(leftFlour);
                    flour = new Stack<double>(newStack);
                }
            }

            foreach (var item in products.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            if (water.Count == 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }

            if (flour.Count == 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
