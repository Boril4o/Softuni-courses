using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = mathPower(number, power);

            Console.WriteLine(result);
        }

        static double mathPower(double number, double power)
        {
            double sum = Math.Pow(number, power);

            return sum;
        }
    }
}
