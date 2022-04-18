using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                int currentNumber = i;
                for (int j = 2; j < currentNumber; j++)
                {
                    if (currentNumber % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", currentNumber);
                }
                else
                {
                    Console.WriteLine("{0} -> false", currentNumber);

                }
            }
        }
    }
}
