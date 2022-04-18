using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num1Factorial = FactorialNum(num1);
            double num2Factorial = FactorialNum(num2);
            double divisionSum = num1Factorial / num2Factorial;
            Console.WriteLine($"{divisionSum:f2}");
        }

        static double FactorialNum(double num)
        {
            double sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum = sum * i;
            }

            return sum;
        }

    }
}
