using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        private string TypeOfVehicle_;
        private string Model_;
        private string Color_;
        private int Horsepower_;

        public Vehicle(string typeOfVehicle, string model, string color, int horseower)
        {
            this.TypeOfVehicle_ = typeOfVehicle;
            this.Model_ = model;
            this.Color_ = color;
            this.Horsepower_ = horseower;
        }

        public string TypeOfVehicle { get => TypeOfVehicle_; set => TypeOfVehicle_ = value; }

        public string Model { get => Model_; set => Model_ = value; }

        public string Color { get => Color_; set => Color_ = value; }

        public int Horsepower { get => Horsepower_; set => Horsepower_ = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] vehicleInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsepower = int.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsepower);
                if (typeOfVehicle == "car")
                {
                    vehicle.TypeOfVehicle = "Car";
                    cars.Add(vehicle);
                }
                else
                {
                    vehicle.TypeOfVehicle = "Truck";
                    trucks.Add(vehicle);
                }

                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            string vehicleModel = Console.ReadLine();
            while (vehicleModel != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == vehicleModel)
                    {
                        Console.WriteLine($"Type: {vehicle.TypeOfVehicle}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }

                vehicleModel = Console.ReadLine();
            }

            double carsAvgHp = cars.Any() ? cars.Average(car => car.Horsepower) : 0.0;
            double trucksAvgHp = trucks.Any() ? trucks.Average(truck => truck.Horsepower) : 0.0;
            Console.WriteLine($"Cars have average horsepower of: {carsAvgHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHp:f2}.");
        }
    }
}
