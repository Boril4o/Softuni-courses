using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string problem = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < problem.Length; i++)
            {
                char currSymbol = problem[i];
                if (currSymbol == '(')
                {
                    indexes.Push(i);
                }
                else if (currSymbol == ')')
                {
                    int closeBracketIndex = indexes.Pop();
                    Console.WriteLine(problem.Substring(closeBracketIndex, i - closeBracketIndex + 1));
                }
            }
        }
    }
}
