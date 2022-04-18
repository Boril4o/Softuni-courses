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
            Dictionary<int, int> counter = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!counter.ContainsKey(num))
                {
                    counter.Add(num, 0);
                }

                counter[num]++;
            }

            foreach (var item in counter)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    return;
                }
            }
        }
    }
}
