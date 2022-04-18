using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WORKERS_CONSUME = 26;
            int startingYield = int.Parse(Console.ReadLine());
            int totalYield = 0;
            int daysCount = 0;

            while (startingYield >= 100)
            {
                int Yield = startingYield;
                daysCount++;
                if (WORKERS_CONSUME < startingYield)
                {
                    Yield -= WORKERS_CONSUME;
                    totalYield += Yield;
                }

                startingYield -= 10;
                if (startingYield < 100 && WORKERS_CONSUME < startingYield)
                {
                    totalYield -= WORKERS_CONSUME;
                }

            }
            Console.WriteLine(daysCount);
            Console.WriteLine(totalYield);

        }
    }
}
