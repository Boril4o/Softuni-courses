using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] contestPassword = input
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string contest = contestPassword[0];
                string password = contestPassword[1];

                contests[contest] = password;

                input = Console.ReadLine();
            }

            var users = new Dictionary<string, Dictionary<string, int>>();
            string input1 = Console.ReadLine();
            while (input1 != "end of submissions")
            {
                string[] line = input1
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = line[0];
                string password = line[1];
                string user = line[2];
                int points = int.Parse(line[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, new Dictionary<string, int>());
                        users[user].Add(contest, points);
                    }
                    else
                    {
                        if (users[user].ContainsKey(contest) && points > users[user][contest])
                        {
                            users[user][contest] = points;
                        }
                        else
                        {
                            if (users[user].ContainsKey(contest))
                            {
                                input1 = Console.ReadLine();
                                continue;
                            }
                            users[user].Add(contest, points);
                        }
                    }
                }

                input1 = Console.ReadLine();
            }

            if (users.Count == 0) return;

            Dictionary<string, int> userTotalPoints = new Dictionary<string, int>();
            foreach (var user in users)
            {
                int sum = 0;
                foreach (var item in user.Value)
                {
                    sum += item.Value;
                }

                userTotalPoints.Add(user.Key, sum);
            }

            userTotalPoints = userTotalPoints
                .OrderByDescending(u => u.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine($"Best candidate is {userTotalPoints.First().Key} " +
                $"with total {userTotalPoints.First().Value} points.");

            Console.WriteLine("Ranking: ");
            foreach (var user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var item in user.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
