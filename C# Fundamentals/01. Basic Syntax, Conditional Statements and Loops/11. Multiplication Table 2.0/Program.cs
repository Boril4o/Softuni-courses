using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            var n = int.Parse(Console.ReadLine());
            var numbers = int.Parse(Console.ReadLine());
            var k = 10;
            i = numbers;

            if (numbers > 10)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                return;
            }

            for (; k >= numbers; i++)
            {
                k--;
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
