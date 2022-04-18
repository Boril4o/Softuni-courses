using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int firstTwoSum = CollectFirstTwoNums(num1, num2);
            int SubtractSum = SubtractSumByNum3(firstTwoSum, num3);

            Console.WriteLine(SubtractSum);
        }

        static int CollectFirstTwoNums(int num1, int num2)
        {
            return num1 + num2;
        }       

        static int SubtractSumByNum3(int sum, int num3)
        {
            return sum - num3;
        }
    }
}
