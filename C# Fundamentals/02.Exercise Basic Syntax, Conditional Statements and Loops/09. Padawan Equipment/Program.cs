using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfMoney = double.Parse(Console.ReadLine());
            var countOfStudents = int.Parse(Console.ReadLine());
            var priceLightsabers = double.Parse(Console.ReadLine());
            var priceRobes = double.Parse(Console.ReadLine());
            var priceBelts = double.Parse(Console.ReadLine());
            var totalSum = 0.0;


            // Belts Sum 
            int freeBelts = countOfStudents / 6;
            freeBelts = countOfStudents - freeBelts;
            double sumBelts = priceBelts * freeBelts;

            //lightsabers Sum            
            double sumlightsabers = priceLightsabers * (countOfStudents + Math.Ceiling(countOfStudents * 0.10));
            
            //robes Sum
            double sumRobes = priceRobes * countOfStudents;

            totalSum = sumlightsabers + sumBelts + sumRobes;

            if (amountOfMoney >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                var needMoney = Math.Abs(amountOfMoney - totalSum);
                Console.WriteLine($"John will need {needMoney:f2}lv more.");
            }
        }
    }
}
