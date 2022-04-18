using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char[]> words = new Dictionary<string, char[]>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                char[] word = input.ToCharArray().Reverse().ToArray();
                words.Add(input, word);
                input = Console.ReadLine();
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} = {string.Join("", word.Value)}");
            }
        }
    }
}
