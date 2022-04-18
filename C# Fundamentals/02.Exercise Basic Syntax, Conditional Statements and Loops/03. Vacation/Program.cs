using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupOfPeople = int.Parse(Console.ReadLine());
            var typeGroup = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var price = 0.0;

            if (typeGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                }
            }

            if (typeGroup == "Students" && groupOfPeople >= 30)
            {
                price -= price * 0.15;
            }
            else if (typeGroup == "Business" && groupOfPeople >= 100)
            {
                groupOfPeople -= 10;
            }
            else if (typeGroup == "Regular" && groupOfPeople >= 10 &&
               groupOfPeople <= 20)
            {
                price -= price * 0.5;
            }

            var totalPrice = groupOfPeople * price;
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
