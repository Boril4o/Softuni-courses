using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> kids = new Queue<string>(names);
            int count = int.Parse(Console.ReadLine());
            int currCount = 1;

            while (kids.Count > 1)
            {
                string currKid = kids.Dequeue();

                if (count != currCount)
                {
                    kids.Enqueue(currKid);
                    currCount++;
                }
                else
                {
                    Console.WriteLine($"Removed {currKid}");
                    currCount = 1;
                }
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
