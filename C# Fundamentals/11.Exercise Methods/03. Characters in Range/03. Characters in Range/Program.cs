using System;
using System.Text;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            string result = CharactersInRange(char1, char2);

            Console.WriteLine(result);
        }

        static string CharactersInRange(char c1, char c2)
        {
            if (c1 > c2)
            {
                char currChar = c1;
                c1 = c2;
                c2 = currChar;
            }

            StringBuilder charactersBetween = new StringBuilder();
            for (int i = c1 + 1; i < c2; i++)
            {
                char nextChar = (char)i;
                charactersBetween.Append(nextChar + " ");
            }

            return charactersBetween.ToString();
        }
    }
}
