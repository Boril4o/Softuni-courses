using System;

namespace _1._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                //Finding name
                int indexOfNameStart = input.IndexOf('@');
                int indexOfNameEnd = input.IndexOf('|');
                string name = input.Substring(indexOfNameStart + 1, indexOfNameEnd - indexOfNameStart - 1);

                //Finding age
                int indexOfAgeStart = input.IndexOf('#');
                int indexOfAgeEnd = input.IndexOf('*');
                string ageStr = input.Substring(indexOfAgeStart + 1, indexOfAgeEnd - indexOfAgeStart - 1);

                //print
                Console.WriteLine($"{name} is {ageStr} years old.");
            }
        }
    }
}
