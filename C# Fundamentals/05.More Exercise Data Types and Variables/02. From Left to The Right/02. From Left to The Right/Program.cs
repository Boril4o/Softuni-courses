using System;
using System.Linq;


namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var numbers = new long[2];
            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(long.Parse)
                    .ToArray();

                long leftNumber = numbers[0];
                long rightNumber = numbers[1];
                if (rightNumber > leftNumber)
                {
                    leftNumber = rightNumber;
                }

                leftNumber = Math.Abs(leftNumber);
                long numberSum = 0;
                long number = 0;
                while (leftNumber > 0)
                {
                    number = leftNumber % 10;
                    numberSum += number;
                    leftNumber /= 10;
                }
                Console.WriteLine(numberSum);
            }
        }
    }
}
