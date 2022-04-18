using System;
using System.Linq;

namespace Problem_3___Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhoods = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "Love!")
            {
                string[] cmd = command
                    .Split(' ')
                    .ToArray();

                int jumpIndex = int.Parse(cmd[1]);
                while (true)
                {
                    if (jumpIndex! >= neighborhoods.Length) break;
                  
                }
            }
        }
    }
}
