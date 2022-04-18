using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] command = input.Split(" | ");
                    string forceSide = command[0];
                    string forceUser = command[1];

                    if (forceSides.ContainsKey(forceSide))
                    {
                        if (!forceSides.Any(side => side.Value.Contains(forceUser)))
                        {
                            forceSides[forceSide].Add(forceUser);
                        }
                    }
                    else
                    {
                        forceSides[forceSide] = new List<string>();
                        forceSides[forceSide].Add(forceUser);
                    }
                }
                else
                {
                    string[] command = input.Split(" -> ");
                    string forceUser = command[0];
                    string forceSide = command[1];

                    if (!forceSides.ContainsKey(forceSide))
                    {
                        forceSides[forceSide] = new List<string>();
                        forceSides[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        input = Console.ReadLine();
                        continue;
                    }

                    bool isUserDuplicate = true;
                    foreach (var side in forceSides)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            if (forceSides[forceSide].Contains(forceUser))
                            {
                                isUserDuplicate = false;
                                break;
                            }
                            side.Value.Remove(forceUser);
                        }
                    }

                    if (isUserDuplicate)
                    {
                        forceSides[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }

                input = Console.ReadLine();
            }

            forceSides = forceSides
                .OrderByDescending(side => side.Value.Count)
                .ThenBy(side => side.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var side in forceSides)
            {
                if (side.Value.Count == 0) continue;

                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(u => u))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
