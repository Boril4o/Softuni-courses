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

            Console.WriteLine(box.ToString());
        }
    }
}


