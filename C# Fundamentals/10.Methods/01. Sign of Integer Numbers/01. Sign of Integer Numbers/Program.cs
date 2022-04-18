using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = signChecker(num);
            Console.WriteLine(result);
        }

        static string signChecker(int number)
        {
            string result = string.Empty;
            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }

            return $"The number {number} is {result}.";
        }
    }
}
