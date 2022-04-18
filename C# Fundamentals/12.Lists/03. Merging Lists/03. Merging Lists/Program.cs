using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>(firstList.Count + secondList.Count);

            int limit = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < limit; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                result.AddRange(GetRemainingElements(firstList, secondList));
            }
            else if (firstList.Count < secondList.Count)
            {
                result.AddRange(GetRemainingElements(secondList, firstList));
            }

            Console.WriteLine(string.Join(" ", result));
        }

        static List<int> GetRemainingElements(List< int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);
            }

            return nums;
        }
    }
}
