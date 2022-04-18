using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValues = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothesValues);

            int countOfRacks = 1;
            int currentAmountOfClothes = 0;
            while (stack.Count > 0)
            {
                int currClothes = stack.Pop();
                int clothesSum = currentAmountOfClothes + currClothes;
                if (clothesSum > capacity)
                {
                    countOfRacks++;
                    currentAmountOfClothes = currClothes;
                }
                else if (clothesSum == capacity && stack.Count > 0)
                {
                    countOfRacks++;
                    currentAmountOfClothes = 0;
                }
                else
                {
                    currentAmountOfClothes += currClothes;
                }
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
