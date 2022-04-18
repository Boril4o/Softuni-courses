using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine()
                          .Split("\\", StringSplitOptions.RemoveEmptyEntries)
                           .Last()
                          .Split('.');

            Console.WriteLine($"File name: {file[0]} \nFile extension: {file[1]}");
        }
    }
}
