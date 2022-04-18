using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = ReadMatrix(rows, cols);

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmdSplitted = command.Split(" ");
                bool isInputCorrect = cmdSplitted.Length == 5 && cmdSplitted[0] == "swap" &&
                    int.Parse(cmdSplitted[1]) >= 0 && int.Parse(cmdSplitted[1]) < rows &&
                    int.Parse(cmdSplitted[2]) >= 0 && int.Parse(cmdSplitted[2]) < cols &&
                    int.Parse(cmdSplitted[3]) >= 0 && int.Parse(cmdSplitted[3]) < rows &&
                    int.Parse(cmdSplitted[4]) >= 0 && int.Parse(cmdSplitted[4]) < cols;

                if (isInputCorrect)
                {
                    string firstElement = matrix[int.Parse(cmdSplitted[1]), int.Parse(cmdSplitted[2])];
                    matrix[int.Parse(cmdSplitted[1]), int.Parse(cmdSplitted[2])] = matrix[int.Parse(cmdSplitted[3]), int.Parse(cmdSplitted[4])];
                    matrix[int.Parse(cmdSplitted[3]), int.Parse(cmdSplitted[4])] = firstElement;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static string[] ReadArray(string splitted)
        {
            return Console.ReadLine()
                    .Split(splitted, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] colElements = ReadArray(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            return matrix;
        }
    }

}


