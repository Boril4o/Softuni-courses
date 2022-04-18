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
            int[][] matrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] colElements = ReadArray(" ");
                matrix[row] = colElements;
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                if (row == matrix.Length - 1)
                {
                    break;
                }

                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix = MultiplyMatrixRow(matrix, row);
                }
                else
                {
                    matrix = DivideMatrixRow(matrix, row);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandSplitted = command.Split(" ");

                if (commandSplitted[0] == "Add")
                {
                    int row = int.Parse(commandSplitted[1]);
                    int col = int.Parse(commandSplitted[2]);
                    int value = int.Parse(commandSplitted[3]);

                    if (matrix.Length > row && row >= 0 && matrix[row].Length > col && col >= 0)
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (commandSplitted[0] == "Subtract")
                {
                    int row = int.Parse(commandSplitted[1]);
                    int col = int.Parse(commandSplitted[2]);
                    int value = int.Parse(commandSplitted[3]);

                    if (matrix.Length > row && row >= 0 && matrix[row].Length > col && col >= 0)
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static int[][] MultiplyMatrixRow(int[][] matrix, int row)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] *= 2;
                matrix[row + 1][col] *= 2;
            }

            return matrix;
        }

        private static int[][] DivideMatrixRow(int[][] matrix, int row)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] /= 2;
            }


            for (int col = 0; col < matrix[row + 1].Length; col++)
            {
                matrix[row + 1][col] /= 2;
            }


            return matrix;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[] ReadArray(string splitted)
        {
            return Console.ReadLine()
                    .Split(splitted, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colElements = ReadArray(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            return matrix;
        }
    }

}


