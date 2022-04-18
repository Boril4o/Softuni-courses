using System;
using System.Linq;
namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;

            for (int wagon = 0; wagon < wagons.Length; wagon++)
            {
                wagons[wagon] = int.Parse(Console.ReadLine());
                sum += wagons[wagon];
            }

            Console.WriteLine(string.Join(' ', wagons));
            Console.WriteLine(sum);
        }
    }
}
