using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int result = rectangleArea(length, height);

            Console.WriteLine(result);
        }

        static int rectangleArea(int length, int height)
        {
            int area = length * height;
            return area;
        }
    }
}
