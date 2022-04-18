using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace test
{

    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int n = input[0];
            int m = input[1];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

            HashSet<int> uniqueElements = FindUniqueElements(firstSet, secondSet);

            Console.WriteLine(string.Join(" ", uniqueElements));
        }

        private static HashSet<int> FindUniqueElements(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            HashSet<int> result = new HashSet<int>();
            if (firstSet.Count > secondSet.Count)
            {
                foreach (var item in firstSet)
                {
                    if (secondSet.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in secondSet)
                {
                    if (firstSet.Contains(item))
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }
    }
}
