using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            string text = Console.ReadLine();

            int previousIndex = 0;
            for (int i = 1; i < text.Length; i++)
            {
                char currLetter = text[i];
                if (currLetter != text[previousIndex])
                {
                    sb.Append(text[previousIndex]);
                }

                previousIndex++;
            }

            sb.Append(text[^1]);
            Console.WriteLine(sb);
        }
    }
}
