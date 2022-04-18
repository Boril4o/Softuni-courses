using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder onlyDigits = new StringBuilder();
            StringBuilder onlyLetters = new StringBuilder();
            StringBuilder others = new StringBuilder();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (char.IsDigit(letter))
                {
                    onlyDigits.Append(letter);
                }
                else if (char.IsLetter(letter))
                {
                    onlyLetters.Append(letter);
                }
                else
                {
                    others.Append(letter);
                }
            }

            Console.WriteLine(onlyDigits);
            Console.WriteLine(onlyLetters);
            Console.WriteLine(others);
        }
    }
}
