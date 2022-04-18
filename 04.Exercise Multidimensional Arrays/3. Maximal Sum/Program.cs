using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace test
{

    public class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = ReadMatrix(rows, cols);


            int maxSum = int.MinValue;
            int[] indexOfMaxSum = new int[2];
            for (int row = 0; row < rows - 2; row++)
            {
                int sum = 0;
                for (int col = 0; col < cols - 2; col++)
                {
                    sum = matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row, col + 2] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1] +
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col] +
                        matrix[row + 2, col + 1] +
                        matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        indexOfMaxSum[0] = row;
                        indexOfMaxSum[1] = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(matrix[indexOfMaxSum[0] + i, indexOfMaxSum[1]] + " ");
                Console.Write(matrix[indexOfMaxSum[0] + i, indexOfMaxSum[1] + 1] + " ");
                Console.Write(matrix[indexOfMaxSum[0] + i, indexOfMaxSum[1] + 2] + " ");
                Console.WriteLine();
            }
        }

        static int[] ReadArray()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] colElements = ReadArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            return matrix;
        }
    }
}
