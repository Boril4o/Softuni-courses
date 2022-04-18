using System;
using System.Globalization;
namespace _13._Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
               "d.m.yyyy",
               CultureInfo.InvariantCulture);

            var endDate = DateTime.ParseExact(Console.ReadLine(),
               "d.m.yyyy",
               CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (var date = startDate; date >= endDate;)
            {
                endDate.AddDays(1);

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}
