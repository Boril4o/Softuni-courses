using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songsNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(songsNames);

            while (true)
            {
                string command = Console.ReadLine();
                string[] commandSplitted = command.Split(" ", 2);

                if (commandSplitted[0] == "Play")
                {
                    queue.Dequeue();
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (commandSplitted[0] == "Add")
                {
                    string song = commandSplitted[1];

                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (commandSplitted[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
        }
    }
}
