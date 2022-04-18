using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Product
    {
        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public double Price { get; set; }

        public int Quantity { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input = Console.ReadLine();
            while (input != "buy")
            {
                string[] productInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                if (!products.ContainsKey(name))
                {
                    Product product = new Product(price, quantity);
                    products.Add(name, product);
                }
                else
                {
                    products[name].Quantity += quantity;
                    products[name].Price = price;
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.Price * product.Value.Quantity:f2}");
            }
        }
    }
}
