using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();

            string[] words = Console.ReadLine().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                string lowerCaseWord = words[i].ToLower();
                if (count.ContainsKey(lowerCaseWord))
                {
                    count[lowerCaseWord]++;
                }
                else
                {
                    count.Add(lowerCaseWord, 1);
                }
            }

            foreach (var word in count)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
