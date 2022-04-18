using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registeredUsers = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "register")
                {
                    string username = command[1];
                    string plateNumber = command[2];

                    if (registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        continue;
                    }

                    registeredUsers.Add(username, plateNumber);
                    Console.WriteLine($"{username} registered {plateNumber} successfully");
                }
                else
                {
                    string username = command[1];

                    if (!registeredUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }

                    registeredUsers.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }

            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
