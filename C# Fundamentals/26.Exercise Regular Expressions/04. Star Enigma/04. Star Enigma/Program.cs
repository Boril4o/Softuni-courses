using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Star_Enigma
{
    class Planet
    {
        public Planet(string name, string attackType)
        {
            Name = name;
            AttackType = attackType;
        }

        public string Name { get; set; }

        public string AttackType { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"@(?<name>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>(?:A|D))[^@\-!:>]*!->(?<soldierCount>\d+)");
            List<Planet> attackedPlanets = new List<Planet>();
            List<Planet> destroyedPlanets = new List<Planet>();


            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int count = 0;

                foreach (var currChar in text)
                {
                    if (currChar == 'S' || currChar == 'T' || currChar == 'A' || currChar == 'R' || currChar == 's' || currChar == 't'
                        || currChar == 'a' || currChar == 'r')
                    {
                        count++;
                    }
                }

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < text.Length; j++)
                {
                    char currChar = text[j];
                    int newChar = (int)currChar - count;
                    sb.Append((char)newChar);
                }

                text = sb.ToString();

                MatchCollection matchCollection = regex.Matches(text);
                if (matchCollection.Count == 1)
                {
                    string name = matchCollection[0].Groups["name"].Value;
                    string attackType = matchCollection[0].Groups["attackType"].Value;
                    Planet planet = new Planet(name, attackType);

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var planet in destroyedPlanets.OrderBy(x => x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }
        }
    }
}
