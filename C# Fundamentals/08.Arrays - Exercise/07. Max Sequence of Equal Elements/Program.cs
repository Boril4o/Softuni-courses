using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bestSequenceSize = 0;
            int bestSeuenceNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int seuenceSize = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];
                    if (currentNumber == rightNumber)
                    {
                        seuenceSize += 1;
                    }
                    else
                    {

                        break;
                    }
                }

                if (seuenceSize > bestSequenceSize)
                {
                    bestSequenceSize = seuenceSize;                   
                    bestSeuenceNumber = currentNumber;
                }

            }
            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSeuenceNumber} ");
            }
        }
    }
}
