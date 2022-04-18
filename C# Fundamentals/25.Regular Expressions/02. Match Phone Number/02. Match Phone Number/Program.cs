using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();
            Regex regex = new Regex(@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");
                                     //(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b
            MatchCollection matches = regex.Matches(phones);

            string[] matchedPhones = matches
                .Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
