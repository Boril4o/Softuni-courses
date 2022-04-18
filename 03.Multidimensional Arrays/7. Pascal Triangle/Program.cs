using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace test
{

    public class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] triangle = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                triangle[row][^1] = 1;

                for (int col = 2; col < triangle[row].Length; col++)
                {
                    triangle[row][col - 1] = triangle[row - 1][col - 1]
                        + triangle[row - 1][col - 2];
                }
            }

            for (int row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine(string.Join(" ", triangle[row]));
            }

        }


    }
}
