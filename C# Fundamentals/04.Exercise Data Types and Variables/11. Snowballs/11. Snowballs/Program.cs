using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSmowballs = int.Parse(Console.ReadLine());
            double maxsnowballValue = double.MinValue;
            double maxSnowballSnow = 0;
            double maxSnowballTime = 0;
            double maxSnowballQuality = 0;

            for (var snowball = 0; snowball < numberOfSmowballs; snowball++)
            {
                double snowballSnow = int.Parse(Console.ReadLine());
                double snowballTime = int.Parse(Console.ReadLine());
                double snowballQuality = int.Parse(Console.ReadLine());

                double snowballValue = Math.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > maxsnowballValue)
                {
                    maxSnowballSnow = snowballSnow;
                    maxSnowballTime = snowballTime;
                    maxSnowballQuality = snowballQuality;
                    maxsnowballValue = snowballValue;
                }
            }

            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxsnowballValue} ({maxSnowballQuality})");


        }
    }
}
