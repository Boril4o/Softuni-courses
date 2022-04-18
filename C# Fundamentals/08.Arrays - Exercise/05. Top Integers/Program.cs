using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();



            for (int i = 0; i < array.Length; i++)
            {
                bool isBigger = true;
                int currentNumber = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightNumber = array[j];

                    if (currentNumber <= rightNumber)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
