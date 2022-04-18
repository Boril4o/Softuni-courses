using System;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split('|')
                .ToArray();

            int healt = 100;
            int bitcoins = 0;
            for (int currRoom = 0; currRoom < rooms.Length; currRoom++)
            {
                string[] command = rooms[currRoom]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "potion")
                {
                    int newHealt = int.Parse(command[1]);
                    if (newHealt + healt > 100)
                    {
                        newHealt = 100 - healt;
                        healt = 100;
                    }
                    else
                    {
                        healt += newHealt;
                    }

                    Console.WriteLine($"You healed for {newHealt} hp.");
                    Console.WriteLine($"Current health: {healt} hp.");
                }
                else if (command[0] == "chest")
                {
                    int foundBitcoins = int.Parse(command[1]);
                    bitcoins += foundBitcoins;
                    Console.WriteLine($"You found {foundBitcoins} bitcoins.");
                }
                else
                {
                    string monsterName = command[0];
                    int monsterHealt = int.Parse(command[1]);
                    if (healt - monsterHealt > 0)
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                        healt -= monsterHealt;
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {currRoom + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {healt}");
        }
    }
}
