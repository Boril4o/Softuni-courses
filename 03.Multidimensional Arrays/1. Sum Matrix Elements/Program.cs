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
            int sum = 0;

            for (int row = 0; row < rowLength; row++)
            {
                int[] colElements = ReadArray(", ");

                for (int col = 0; col < colLength; col++)
                {
                    matrix[row, col] = colElements[col];
                    sum += colElements[col];
                }
            }

            Console.WriteLine(rowLength);
            Console.WriteLine(colLength);
            Console.WriteLine(sum);
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


