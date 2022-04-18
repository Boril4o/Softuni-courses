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
            int matrixRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[matrixRows][];

            for (int row = 0; row < matrixRows; row++)
            {
                int[] colElements = ReadArray(" ");
                jaggedArray[row] = new int[colElements.Length];
                for (int col = 0; col < colElements.Length; col++)
                {
                    jaggedArray[row][col] = colElements[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] splittedCommand = command.Split(" ").ToArray();

                if (splittedCommand[0] == "Add")
                {
                    int row = int.Parse(splittedCommand[1]);
                    int col = int.Parse(splittedCommand[2]);
                    int value = int.Parse(splittedCommand[3]);

                    if (row >= jaggedArray.Length || row < 0 || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        command = Console.ReadLine();
                        continue;
                    }

                    jaggedArray[row][col] += value;

                }
                else if (splittedCommand[0] == "Subtract")
                {
                    int row = int.Parse(splittedCommand[1]);
                    int col = int.Parse(splittedCommand[2]);
                    int value = int.Parse(splittedCommand[3]);

                    if (row >= jaggedArray.Length || row < 0 || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        command = Console.ReadLine();
                        continue;
                    }

                    jaggedArray[row][col] -= value;

                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < matrixRows; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
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
