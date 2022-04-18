using System;

namespace _1._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var outPut = "";

            if (age >= 0 && age <= 2)
            {
                outPut = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                outPut = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                outPut = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                outPut = "adult";
            }
            else
            {
                outPut = "elder";
            }

            Console.WriteLine(outPut);
        }
    }
}
