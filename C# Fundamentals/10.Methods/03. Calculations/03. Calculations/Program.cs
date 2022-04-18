using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeCalculation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;

            if (typeCalculation == "add")
            {
                result = add(firstNum, secondNum);
            }
            else if (typeCalculation == "multiply")
            {
                result = multiply(firstNum, secondNum);
            }
            else if (typeCalculation == "subtract")
            {
                result = subtract(firstNum, secondNum);
            }
            else
            {
                result = divide(firstNum, secondNum);
            }

            Console.WriteLine(result);
        }

        static int add(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;

            return sum;
        }

        static int multiply(int firstNum, int secondNum)
        {
            int sum = firstNum * secondNum;

            return sum;
        }

        static int subtract(int firstNum, int secondNum)
        {
            int sum = firstNum - secondNum;

            return Math.Abs(sum);
        }

        static int divide(int firstNum, int secondNum)
        {
            int sum = firstNum / secondNum;

            return Math.Abs(sum);
        }
    }
}
