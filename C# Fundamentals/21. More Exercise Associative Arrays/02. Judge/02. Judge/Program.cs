using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> maxResults = new Dictionary<string, int>();
            var contests = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "no more time")
            {
                string[] contestInfo = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string username = contestInfo[0];
                string contest = contestInfo[1];
                int points = int.Parse(contestInfo[2]);

                if (!contests.ContainsKey(contest))
                {
                    if (maxResults.ContainsKey(username))
                    {
                        maxResults[username] += points;
                    }
                    else
                    {
                        maxResults.Add(username, points);
                    }
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(username, points);
                }
                else
                {
                    if (contests[contest].ContainsKey(username))
                    {
                        if (contests[contest][username] < points)
                        {
                            maxResults[username] = points;
                            contests[contest][username] = points;
                        }
                    }
                    else
                    {
                        if (maxResults.ContainsKey(username))
                        {

                            maxResults[username] += points;

                        }
                        else
                        {
                            maxResults.Add(username, points);
                        }

                        contests[contest].Add(username, points);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Values.Count} participants");
                int count = 0;
                foreach (var user in contest.Value.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {user.Key} <::> {user.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            int num = 0;
            foreach (var user in maxResults.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
            {
                num++;
                Console.WriteLine($"{num}. {user.Key} -> {user.Value}");
            }
        }
    }
}
