using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());

            decimal USDollars = britishPounds * 1.31M;
            Console.WriteLine($"{USDollars:f3}");
        }

    }
}
