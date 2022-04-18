using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        int year;
        double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year { get { return year; } set { year = value; } }
        public double Pressure { get { return pressure; } set { pressure = value; } }

        public static double GetSumOfPressure(Tire[] tires)
        {
            double sum = 0;
            foreach (var tire in tires)
            {
                sum += tire.Pressure;
            }

            return sum;
        }
    }
}
