using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = ReadCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            char specialSymbol = char.Parse(Console.ReadLine());
            int[] symbolPosition = new int[2];
            bool isFound = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currSymbol = matrix[row, col];
                    if (currSymbol == specialSymbol)
                    {
                        isFound = true;
                        symbolPosition[0] = row;
                        symbolPosition[1] = col;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"({symbolPosition[0]}, {symbolPosition[1]})");
            }
            else
            {
                Console.WriteLine($"{specialSymbol} does not occur in the matrix");
            }
        }

        static int[] ReadArray(string splitted)
        {
            return Console.ReadLine()
                    .Split(splitted, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
        }

        static char[] ReadCharArray()
        {
            string input = Console.ReadLine();
            char[] array = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = input[i];
            }

            return array;
        }
    }

}


