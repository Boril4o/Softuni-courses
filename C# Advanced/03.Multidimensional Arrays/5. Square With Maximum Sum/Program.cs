using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray(", ");
            int rowLength = sizes[0];
            int colLength = sizes[1];

            int[,] matrix = new int[rowLength, colLength];

            for (int row = 0; row < rowLength; row++)
            {
                int[] colElements = ReadArray(", ");
                for (int col = 0; col < colLength; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int[] position = new int[2];
            int maxSum = int.MinValue;
            for (int row = 0; row < rowLength - 1; row++)
            {
                for (int col = 0; col < colLength - 1; col++)
                {
                    int currSum = matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1];

                    if (currSum > maxSum)
                    {
                        position[0] = row;
                        position[1] = col;
                        maxSum = currSum;
                    }
                }
            }

            Console.WriteLine($"{matrix[position[0], position[1]]} {matrix[position[0], position[1] + 1]}");
            Console.WriteLine($"{matrix[position[0] + 1, position[1]]} {matrix[position[0] + 1, position[1] + 1]}");
            Console.WriteLine(maxSum);
        }

        static int[] ReadArray(string splitted)
        {
            return Console.ReadLine()
                    .Split(splitted, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
        }


    }

}


