using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string firstNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum[0] == '0' || secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int reminder = 0;
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int sum = (int.Parse(firstNum[i].ToString()) * secondNum + reminder);
                reminder = sum / 10;
                builder.Insert(0, sum % 10);
            }

            if (reminder > 0)
            {
                builder.Insert(0, reminder);
            }

            Console.WriteLine(builder);
        }
    }
}
