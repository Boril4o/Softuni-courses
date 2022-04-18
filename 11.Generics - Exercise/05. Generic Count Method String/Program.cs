using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                box.items.Add(item);
            }

            string compareItem = Console.ReadLine();
            Console.WriteLine(box.Compare(compareItem));
        }
    }
}


