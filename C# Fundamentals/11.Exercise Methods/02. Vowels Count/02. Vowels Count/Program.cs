using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int result = VowelsCount(text);

            Console.WriteLine(result);
        }

        static int VowelsCount(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                bool isVowel = "aeiouAEIOU".IndexOf(letter) >= 0;
                if (isVowel)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
