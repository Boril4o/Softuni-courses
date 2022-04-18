using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int sum = 0;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                number = i;
                while (number != 0)
                {
                    if (i == 5 || i == 7)
                    {
                        sum = number;
                        break;
                    }

                    num = number % 10;
                    sum += num;

                    number = number / 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                    sum = 0;
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                    sum = 0;
                }
            }
        }
    }
}
