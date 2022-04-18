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
            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();
            string text = Console.ReadLine();

            foreach (var item in text)
            {
                if (!counter.ContainsKey(item))
                {
                    counter.Add(item, 0);
                }

                counter[item]++;
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
