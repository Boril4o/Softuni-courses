using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool isEven = text.Length % 2 == 0;
            string resultEven = "";
            char resultOdd = ' ';

            if (isEven)
            {
                resultEven = MiddleCharactersEven(text);
                Console.WriteLine(resultEven);
            }
            else
            {
                resultOdd = MiddleCharactersOdd(text);
                Console.WriteLine(resultOdd);
            }

        }

        static string MiddleCharactersEven(string text)
        {
            string middleCharacters = "";
            char firstMiddleChar = text[text.Length / 2];
            char secondMiddleChar = text[text.Length / 2 - 1];
            middleCharacters += secondMiddleChar;
            middleCharacters += firstMiddleChar;

            return middleCharacters;
        }

        static char MiddleCharactersOdd(string text)
        {
            return text[text.Length / 2];
        }
    }
}
