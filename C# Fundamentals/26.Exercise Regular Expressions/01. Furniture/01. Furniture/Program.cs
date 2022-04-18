using System;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)");

            List<string> products = new List<string>();
            double totalPrice = 0;
            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                MatchCollection matchCollection = regex.Matches(input);
                string name = "";
                double price = 0;
                int quantity = 0;

                if (matchCollection.Count == 1)
                {
                    name = matchCollection[0].Groups["name"].Value;
                    price = double.Parse(matchCollection[0].Groups["price"].Value);
                    quantity = int.Parse(matchCollection[0].Groups["quantity"].Value);
                    products.Add(name);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            products.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
