using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char Letter = char.Parse(Console.ReadLine());

            if (Letter == char.ToUpper(Letter))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
               
                                                  
        }
    }
}
