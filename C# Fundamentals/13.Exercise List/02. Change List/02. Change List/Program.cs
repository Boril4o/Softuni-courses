using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int number;
            while (true)
            {
                string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "Delete")
                {
                    number = int.Parse(command[1]);
                    list.RemoveAll(n => n == number);
                }
                else
                {
                    number = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    list.Insert(position, number);
                }
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}
