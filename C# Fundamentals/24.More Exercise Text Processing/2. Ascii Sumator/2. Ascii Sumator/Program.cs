using System;

namespace _2._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int firstCharSum = (int)firstChar;
            int secondSum = (int)secondChar;
            int biggerSum = Math.Max(firstCharSum, secondSum);
            int smallestSum = Math.Min(firstCharSum,secondSum);

            char biggerChar = (char)biggerSum;
            char smallestChar = (char)smallestSum;

            int sum = 0;
            foreach (var letter in text)
            {
                if (biggerChar > letter && letter > smallestChar)
                {
                    sum += (int)letter;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
