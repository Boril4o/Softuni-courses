using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool flag = true;
            while (flag)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < line.Length; i += 2)
                {
                    if (flag == false) break;
                    
                    string item = line[i].ToLower();
                    int value = int.Parse(line[i - 1]);

                    switch (item)
                    {
                        case "shards":
                            items["shards"] += value;
                            if (items["shards"] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                items["shards"] -= 250;
                                flag = false;
                                break;
                            }
                            break;
                        case "fragments":
                            items["fragments"] += value;
                            if (items["fragments"] >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                items["fragments"] -= 250;
                                flag = false;
                                break;
                            }
                            break;
                        case "motes":
                            items["motes"] += value;
                            if (items["motes"] >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                items["motes"] -= 250;
                                flag = false;
                                break;
                            }
                            break;
                        default:
                            if (!junk.ContainsKey(item))
                            {
                                junk.Add(item, 0);
                            }
                            junk[item] += value;
                            break;
                    }
                }
            }

            //print items
            items = items
                .OrderByDescending(item => item.Value)
                .ThenBy(item => item.Key)
                .ToDictionary(key => key.Key, value => value.Value);

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            //print junk items
            junk = junk
                .OrderBy(item => item.Key)
                .ToDictionary(key => key.Key, value => value.Value);

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
