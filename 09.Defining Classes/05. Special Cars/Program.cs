using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            int tiresCounter = 0;
            while (command != "No more tires")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                tires.Add(new Tire[4]);
                int tiresPosition = 0;
                for (int i = 0; i < 8; i++)
                {
                    int year = int.Parse(splittedCommand[i]);
                    double pressure = double.Parse(splittedCommand[i + 1]);
                    Tire tire = new Tire(year, pressure);
                    tires[tiresCounter][tiresPosition] = tire;
                    i++;
                    tiresPosition++;
                }
                command = Console.ReadLine();
                tiresCounter++;
            }

            List<Engine> engines = new List<Engine>();
            command = Console.ReadLine();
            while (command != "Engines done")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int hoursePower = int.Parse(splittedCommand[0]);
                double cubicCapacity = double.Parse(splittedCommand[1]);
                Engine engine = new Engine(hoursePower, cubicCapacity);
                engines.Add(engine);
                command = Console.ReadLine();
            }

            List<Car> cars = new List<Car>();
            command = Console.ReadLine();
            while (command != "Show special")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = splittedCommand[0];
                string model = splittedCommand[1];
                int year = int.Parse(splittedCommand[2]);
                double fuelQuantity = double.Parse(splittedCommand[3]);
                double fuelConsumption = double.Parse(splittedCommand[4]);
                int engineIndex = int.Parse(splittedCommand[5]);
                int tiresIndex = int.Parse(splittedCommand[6]);
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
                command = Console.ReadLine();
            }


            foreach (var car in cars)
            {
                double tireSumPressure = Tire.GetSumOfPressure(car.Tires);
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tireSumPressure > 9 && tireSumPressure < 10)
                {
                    car.FuelQuantity = car.Drive20Kilometers(car.FuelQuantity, car.FuelConsumption);
                    Console.WriteLine($"Make: {car.Make}\n" +
                        $"Model: {car.Model}\n" +
                        $"Year: {car.Year}\n" +
                        $"HorsePowers: {car.Engine.HorsePower}\n" +
                        $"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}


