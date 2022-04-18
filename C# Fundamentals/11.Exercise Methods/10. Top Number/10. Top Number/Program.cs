using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                bool isSumOfdigitIsValid = sumOfDigitsDevisibleisValid(num);
                bool isNumberHoldsOneOddDigit = numberDigitChecker(num);

                if (isSumOfdigitIsValid && isNumberHoldsOneOddDigit)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static bool sumOfDigitsDevisibleisValid(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                sum += lastDigit;
                num /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool numberDigitChecker(int num)
        {
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }
                num /= 10;
            }

            return false;
        }
    }
}
