using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rmWord = Console.ReadLine();
            string text = Console.ReadLine();


            while (text.Contains(rmWord))
            {
                int index = text.IndexOf(rmWord);
                text = text.Remove(index, rmWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}
