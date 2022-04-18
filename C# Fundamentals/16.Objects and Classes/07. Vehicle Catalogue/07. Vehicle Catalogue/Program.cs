using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        private string Brand_;
        private string Model_;
        private string Weight_;

        public Truck(string brand, string model, string weight)
        {
            this.Brand_ = brand;
            this.Model_ = model;
            this.Weight_ = weight;
        }

        public string Brand { get => Brand_; set => Brand_ = value; }

        public string Model { get => Model_; set => Model_ = value; }

        public string Weight { get => Weight_; set => Weight_ = value; }

        public override string ToString() => $"{Brand}: {Model} - {Weight}kg";
    }

    class Car
    {
        private string Brand_;
        private string Model_;
        private string Horsepower_;

        public Car(string brand, string model, string horsepower)
        {
            this.Brand_ = brand;
            this.Model_ = model;
            this.Horsepower_ = horsepower;
        }

        public string Brand { get => Brand_; set => Brand_ = value; }

        public string Model { get => Model_; set => Model_ = value; }

        public string Horsepower { get => Horsepower_; set => Horsepower_ = value; }

        public override string ToString() => $"{Brand}: {Model} - {Horsepower}hp";
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] vehicleInfo = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

                if (vehicleInfo[0] == "Truck")
                {
                    string brand = vehicleInfo[1];
                    string model = vehicleInfo[2];
                    string weight = vehicleInfo[3];
                    Truck truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }
                else
                {
                    string brand = vehicleInfo[1];
                    string model = vehicleInfo[2];
                    string horsepower = vehicleInfo[3];
                    Car car = new Car(brand, model, horsepower);
                    cars.Add(car);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Cars:");
            cars.OrderBy(car => car.Brand).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("Trucks:");
            trucks.OrderBy(truck => truck.Brand).ToList().ForEach(Console.WriteLine);
        }
    }
}
