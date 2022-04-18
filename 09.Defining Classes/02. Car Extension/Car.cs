using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;

        public string Make { get { return this.make; } set { this.make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

        public void Drive(double distance)
        {
            if (FuelQuantity - distance * FuelConsumption > 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Fuel: {FuelQuantity:f2}";
        }
    }
}
