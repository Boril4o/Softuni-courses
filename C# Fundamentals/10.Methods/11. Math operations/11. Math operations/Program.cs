using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            int result = MathCalculator(@operator, firstNumber, secondNumber);

            Console.WriteLine(result);

        }

        static int MathCalculator(string @operator, int firstNumber, int secondNumber)
        {
            int sum = 0;
            if (@operator == "/")
            {
                sum = firstNumber / secondNumber;
            }
            else if (@operator == "*")
            {
                sum = firstNumber * secondNumber;
            }
            else if (@operator == "+")
            {
                sum = firstNumber + secondNumber;
            }
            else
            {
                sum = firstNumber - secondNumber;
            }

            return sum;
        }
    }
}
