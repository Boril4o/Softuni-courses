using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 ||
                   coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();

            }

            string product = Console.ReadLine().ToLower();
            double price = 0;
            while (product != "end")
            {
                if (product == "nuts")
                {
                    price = 2.0;
                }
                else if (product == "water")
                {
                    price = 0.7;
                }
                else if (product == "crisps")
                {
                    price = 1.5;
                }
                else if (product == "soda")
                {
                    price = 0.8;
                }
                else if (product == "coke")
                {
                    price = 1.0;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                if (sum >= price)
                {
                    if (price != 0)
                    {
                        sum -= price;
                        Console.WriteLine($"Purchased {product}");

                    }
                }
                else if (sum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
