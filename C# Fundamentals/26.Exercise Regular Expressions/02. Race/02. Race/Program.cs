using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            string[] participantsNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var name in participantsNames)
            {
                participants.Add(name, 0);
            }

            Regex regexForName = new Regex(@"([A-Za-z])");
            Regex regexForKm = new Regex(@"([0-9])");

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection name = regexForName.Matches(input);
                MatchCollection km = regexForKm.Matches(input);
                string currName = string.Join("", name);
                int currNum = GetNum(string.Join("", km));
                if (name.Count > 0 && km.Count > 1)
                {
                    if (participants.ContainsKey(currName))
                    {
                        participants[currName] += currNum;
                    }
                }

                input = Console.ReadLine();
            }

            var firstThreeParticipants = participants
                .OrderByDescending(x => x.Value)
                .Take(3);

            var first = firstThreeParticipants
                .OrderByDescending(x => x.Value)
                .Take(1);

            var second = firstThreeParticipants
                .OrderBy(x => x.Value)
                .Take(2)
                .OrderByDescending(x => x.Value)
                .Take(1);

            var third = firstThreeParticipants
                .OrderBy(x => x.Value)
                .Take(2)
                .OrderBy(x => x.Value)
                .Take(1);

            Console.WriteLine($"1st place: {first.ToDictionary(k => k.Key, v => v.Value).Keys.First()}");
            Console.WriteLine($"2nd place: {second.ToDictionary(k => k.Key, v => v.Value).Keys.First()}");
            Console.WriteLine($"3rd place: {third.ToDictionary(k => k.Key, v => v.Value).Keys.First()}");
        }

        private static int GetNum(string nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                int currNum = int.Parse(num.ToString());
                sum += currNum;
            }

            return sum;
        }
    }
}
