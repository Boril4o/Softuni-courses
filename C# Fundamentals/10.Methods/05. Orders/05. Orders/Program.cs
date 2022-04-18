using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double result = priceSum(product, count);

            Console.WriteLine($"{result:f2}");
        }

        static double priceSum(string product, int count)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1.00;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else
            {
                price = 2.00;
            }

            return price * count;
        }
    }
}
