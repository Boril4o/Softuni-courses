using System;
using System.Linq;
namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    arr = exchangeArray(index, arr);
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    maxOrMinAndOddOrEvenIndex(command[1], arr);
                }
                else
                {

                }
            }
        }

        static int[] exchangeArray(int splitIndex, int[] arr)
        {
            if (splitIndex >= arr.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            int[] exchangeArray = new int[arr.Length];
            int index = 0;
            for (int i = splitIndex + 1; i < arr.Length; i++)
            {
                exchangeArray[index] = arr[i];
                index++;
            }

            index = 0;
            for (int i = splitIndex; i < arr.Length - 1; i++)
            {
                exchangeArray[i] = arr[index];
                index++;
            }


            foreach (var item in exchangeArray)
            {
                if (item != 0)
                {
                    return exchangeArray;

                }
            }

            return arr;
        }

        static void maxOrMinAndOddOrEvenIndex(string command, int[] arr)
        {
            int evenOrOdd = 1;
            if (command == "even")
            {
                evenOrOdd = 0;
            }

            int maxIndex = int.MinValue;
            int index = 0;
            for (int currentIndex = 0; currentIndex < arr.Length; currentIndex++)
            {
                int currentNumber = arr[currentIndex];
                if (currentNumber % evenOrOdd == 0)
                {
                    index = currentIndex;
                }

                if (index >= maxIndex)
                {
                    maxIndex = index;
                }
            }

            if (maxIndex == int.MinValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }
    }
}
