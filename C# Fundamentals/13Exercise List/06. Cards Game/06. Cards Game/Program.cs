using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0)
            {
                int firstPlayerCard = firstPlayerCards[0];
                int secondPlayerCard = secondPlayerCards[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                    firstPlayerCards.Add(secondPlayerCard);
                    firstPlayerCards.Add(firstPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                    secondPlayerCards.Add(firstPlayerCard);
                    secondPlayerCards.Add(secondPlayerCard);
                }
                else
                {
                    firstPlayerCards.Remove(firstPlayerCard);
                    secondPlayerCards.Remove(secondPlayerCard);
                }
            }

            if (firstPlayerCards.Count > secondPlayerCards.Count)
            {
                int sum = firstPlayerCards.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondPlayerCards.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
