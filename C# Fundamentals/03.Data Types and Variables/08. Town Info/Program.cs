using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string population = Console.ReadLine();
            string area = Console.ReadLine();

            Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
        }
    }
}
