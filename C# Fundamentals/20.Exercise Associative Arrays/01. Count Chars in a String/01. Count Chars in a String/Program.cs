using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, int> count = new Dictionary<char, int>();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter == ' ') continue;
                if (count.ContainsKey(letter))
                {
                    count[letter]++;
                }
                else
                {
                    count.Add(letter, 1);
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
