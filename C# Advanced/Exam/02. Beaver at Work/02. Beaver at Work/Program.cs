using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            int beaverRow = 0;
            int beaverCol = 0;
            int branchesCount = 0;
            for (int row = 0; row < n; row++)
            {
                char[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    field[row, col] = colElements[col];
                    if (field[row, col] == 'B')
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }
                    else if (char.IsLower(field[row, col]))
                    {
                        branchesCount++;
                    }
                }
            }

            string command = Console.ReadLine();
            Stack<char> currBranches = new Stack<char>();
            int beaverAllBrenchesCollect = 0;
            while (command != "end" && beaverAllBrenchesCollect < branchesCount)
            {
                if (command == "up" && beaverRow - 1 >= 0)
                {
                    field[beaverRow, beaverCol] = '-';
                    beaverRow--;
                }
                else if (command == "down" && beaverRow + 1 < field.GetLength(0))
                {
                    field[beaverRow, beaverCol] = '-';
                    beaverRow++;
                }
                else if (command == "left" && beaverCol - 1 >= 0)
                {
                    field[beaverRow, beaverCol] = '-';
                    beaverCol--;
                }
                else if (command == "right" && beaverCol + 1 < field.GetLength(0))
                {
                    field[beaverRow, beaverCol] = '-';
                    beaverCol++;
                }
                else
                {
                    if (currBranches.Count > 0)
                    {
                        currBranches.Pop();
                    }
                    command = Console.ReadLine();
                    continue;
                }

                if (field[beaverRow, beaverCol] == 'F')
                {
                    field[beaverRow, beaverCol] = '-';
                    if (command == "up" && beaverRow == 0)
                    {
                        beaverRow = field.GetLength(0) - 1;
                    }
                    else if (command == "up" && beaverRow - 1 >= 0)
                    {
                        beaverRow = 0;
                    }
                    else if (command == "down" && beaverRow == field.GetLength(0) - 1)
                    {
                        beaverRow = 0;
                    }
                    else if (command == "down" && beaverRow + 1 < field.GetLength(0))
                    {
                        beaverRow = field.GetLength(0) - 1;
                    }
                    else if (command == "right" && beaverCol == field.GetLength(0) - 1)
                    {
                        beaverCol = field.GetLength(0) - 1;
                    }
                    else if (command == "right" && beaverCol + 1 < field.GetLength(0))
                    {
                        beaverCol = field.GetLength(0) - 1;
                    }
                    else if (command == "left" && beaverCol == 0)
                    {
                        beaverCol = 0;
                    }
                    else if (command == "left" && beaverCol - 1 >= 0)
                    {
                        beaverCol = 0;
                    }

                }
                else if (char.IsLower(field[beaverRow, beaverCol]))
                {
                    beaverAllBrenchesCollect++;
                    currBranches.Push(field[beaverRow, beaverCol]);
                }

                field[beaverRow, beaverCol] = 'B';
                command = Console.ReadLine();
            }

            if (beaverAllBrenchesCollect == branchesCount)
            {
                Console.WriteLine($"The Beaver successfully collect {currBranches.Count} wood branches: {string.Join(", ", currBranches.Reverse())}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {branchesCount - beaverAllBrenchesCollect} branches left.");
            }

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (col == field.GetLength(1) - 1)
                    {
                        Console.Write(field[row, col]);
                    }
                    else
                    {
                        Console.Write(field[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
