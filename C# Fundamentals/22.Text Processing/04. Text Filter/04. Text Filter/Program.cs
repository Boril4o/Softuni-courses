using System;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in banWords)
            {
                if (text.Contains(word))
                {
                    char ch = '*';
                    text = text.Replace(word, new string(ch, word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
