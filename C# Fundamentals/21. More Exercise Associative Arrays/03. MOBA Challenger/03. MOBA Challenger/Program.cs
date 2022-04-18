using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, List<Dictionary<string, int>>>();
            var playersPositions = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] command = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string playerName = command[0];
                    string playerPosition = command[1];
                    int playerSkill = int.Parse(command[2]);

                    if (!players.ContainsKey(playerName))
                    {
                        players.Add(playerName, new List<Dictionary<string, int>>());
                        players[playerName].Add(new Dictionary<string, int>());
                        players[playerName][0].Add(playerPosition, playerSkill);

                        playersPositions.Add(playerName, new List<string> { playerPosition });
                    }
                    else
                    {
                        if (players[playerName][0].ContainsKey(playerPosition))
                        {
                            if (players[playerName][0][playerPosition] < playerSkill)
                            {
                                players[playerName][0][playerPosition] = playerSkill;
                            }
                        }
                        else
                        {
                            players[playerName][0].Add(playerPosition, playerSkill);
                            playersPositions[playerName].Add(playerPosition);
                        }
                    }
                }
                else if (input.Contains("vs"))
                {
                    string[] command = input
                   .Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    string firstPlayer = command[0];
                    string secondPlayer = command[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        if (IsHaveSamePositons(firstPlayer, secondPlayer, playersPositions))
                        {
                            string position = GetPosition(firstPlayer, secondPlayer, playersPositions);
                            if (players[firstPlayer][0][position] > players[secondPlayer][0][position])
                            {
                                players.Remove(secondPlayer);
                            }
                            else if (players[firstPlayer][0][position] < players[secondPlayer][0][position])
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> playerTotalPoints = new Dictionary<string, int>();
            foreach (var player in players)
            {
                playerTotalPoints.Add(player.Key, 0);
                foreach (var item in player.Value)
                {
                    foreach (var element in item.Values)
                    {
                        playerTotalPoints[player.Key] += element;
                    }
                }
            }

            foreach (var player in playerTotalPoints.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach (var item in players[player.Key][0].OrderByDescending(s => s.Value).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }

        static bool IsHaveSamePositons(string firstName, string secondName, Dictionary<string, List<string>> positions)
        {
            foreach (var currPositon in positions[firstName])
            {
                string firstPlayerPostition = currPositon;
                foreach (var positon in positions[secondName])
                {
                    string secondPlayerPostition = positon;
                    if (firstPlayerPostition == secondPlayerPostition)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static string GetPosition(string firstName, string secondName, Dictionary<string, List<string>> positions)
        {
            foreach (var currPositon in positions[firstName])
            {
                string firstPlayerPostition = currPositon;
                foreach (var secondPosition in positions[secondName])
                {
                    string secondPlayerPostition = secondPosition;
                    if (firstPlayerPostition == secondPlayerPostition)
                    {
                        return secondPlayerPostition;   
                    }
                }
                
            }

            return null;
        }
    }
}
