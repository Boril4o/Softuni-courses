﻿using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (byte i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
