using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(Multiplier(strings[0], strings[1]));
        }
        private static int Multiplier(string stringOne, string stringTwo)
        {
            int sum = 0;
            int index = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < index; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string biggerString = stringOne.Length > stringTwo.Length ? stringOne : stringTwo;

            for (int i = index; i < biggerString.Length; i++)
            {
                sum += biggerString[i];
            }

            return sum;
        }
    }
}
