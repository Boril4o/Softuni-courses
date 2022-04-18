using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Person
    {
        public Person(string name, string product, double totalPrice)
        {
            Name = name;
            Product = product;
            TotalPrice = totalPrice;
        }

        public string Name { get; set; }

        public string Product { get; set; }

        public double TotalPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+[.]?[\d]+)?\$");

            List<Person> people = new List<Person>();
            string input = Console.ReadLine();
            while (input != "end of shift")
            {
                MatchCollection matchCollection = regex.Matches(input);
                if (matchCollection.Count == 1)
                {
                    string name = matchCollection[0].Groups["name"].Value;
                    string product = matchCollection[0].Groups["product"].Value;
                    int count = int.Parse(matchCollection[0].Groups["count"].Value);
                    double price = double.Parse(matchCollection[0].Groups["price"].Value);

                    Person person = new Person(name, product, price * count);
                    people.Add(person);
                }

                input = Console.ReadLine();
            }


            double totalIncome = 0;
            foreach (var person in people)
            {
                totalIncome += person.TotalPrice;
                Console.WriteLine($"{person.Name}: {person.Product} - {person.TotalPrice:f2}");
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}





