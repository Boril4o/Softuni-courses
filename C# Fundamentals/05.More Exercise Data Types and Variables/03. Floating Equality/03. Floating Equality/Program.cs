using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            const double EPS = 0.000001;
            double n1 = 0.0;
            double n2 = 0.0;

            while (true)
            {
                n1 = double.Parse(Console.ReadLine());
                n2 = double.Parse(Console.ReadLine());
                bool isEqual = Math.Abs(n1 - n2) < EPS;


                if (isEqual)
                {
                    Console.WriteLine("True");

                    return;
                }
                else
                {
                    Console.WriteLine("False");

                    return;
                }
            }

        }
    }
}
