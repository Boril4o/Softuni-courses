using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int currentNumber = 0;
            bool isSpecialNumber = false;
            for (int i = 1; i <= number; i++)
            {
                currentNumber = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                isSpecialNumber = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNumber);
                total = 0;
                i = currentNumber;
            }


        }
    }
}
