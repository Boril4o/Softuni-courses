using System;
using System.Linq;


namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            Console.WriteLine(string.Join('\n', words));
        }
    }
}
