using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace test
{

    public class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dc = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] dresses = input[1].Split(",");
                if (!dc.ContainsKey(color))
                {
                    dc.Add(color, new Dictionary<string, int>());
                }
                for (int k = 0; k < dresses.Length; k++)
                {
                    string currDress = dresses[k];
                    if (!dc[color].ContainsKey(currDress))
                    {
                        dc[color].Add(currDress, 0);
                    }
                    dc[color][currDress]++;
                }
            }
            string[] LookingItem = Console.ReadLine().Split();
            string lookingColor = LookingItem[0];
            string lookingDress = LookingItem[1];
            foreach (var clothes in dc)
            {
                Console.WriteLine($"{clothes.Key} clothes:");
                foreach (var item in clothes.Value)
                {
                    if (lookingColor == clothes.Key && lookingDress == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
