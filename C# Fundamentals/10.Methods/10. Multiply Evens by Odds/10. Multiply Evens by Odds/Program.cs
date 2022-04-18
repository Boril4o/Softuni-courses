using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultiplyOfEvenAndOdds(number);

            Console.WriteLine(result);
        }

        static int GetMultiplyOfEvenAndOdds(int number)
        {
            int evenNumbersSum = GetSumOfEvenDigits(number);
            int oddNumbersSum = GetSumOfOddDigits(number);
            int multiplySums = evenNumbersSum * oddNumbersSum;

            return multiplySums;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
