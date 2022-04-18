using System;

namespace _11._Refactor_Volume_of_Pyramid
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lenght: ");
            var lenght = double.Parse(Console.ReadLine());

            Console.Write($"Width: ");
            var width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            var volume = (lenght * width * height) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
