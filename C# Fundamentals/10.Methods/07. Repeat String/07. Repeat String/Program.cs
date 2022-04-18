using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            string result = repeatString(text, repeats);

            Console.WriteLine(result);
        }

        static string repeatString(string text, int repeats)
        {
            StringBuilder result = new StringBuilder(repeats);
            for (int i = 0; i < repeats; i++)
            {
                result.Append(text);
            }

            return result.ToString();
        }
    }
}
