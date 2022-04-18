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
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                char[] colElements = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int col = 0; col < colElements.Length; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int countOfEqualCells = 0;
            for (int row = 0; row < sizes[0] - 1; row++)
            {
                for (int col = 0; col < sizes[1] - 1; col++)
                {
                    char firsSymbol = matrix[row, col];
                    char secondSymbol = matrix[row, col + 1];
                    char thirdSymbol = matrix[row + 1, col];
                    char fourthSymbol = matrix[row + 1, col + 1];

                    if (firsSymbol == secondSymbol && firsSymbol == thirdSymbol && firsSymbol == fourthSymbol)
                    {
                        countOfEqualCells++;
                    }
                }
            }

            Console.WriteLine(countOfEqualCells);
        }


    }
}
