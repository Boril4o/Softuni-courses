using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Speed_Racing
{
    class Car
    {
        private string _model;
        private double _fuelAmount;
        private double _fuelConsumptionFor1km;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1Km)
        {
            _model = model;
            _fuelAmount = fuelAmount;
            _fuelConsumptionFor1km = fuelConsumptionFor1Km;
        }

        public string Model { get => _model; set => _model = value; }

        private double  FuelAmount { get => _fuelAmount; set => _fuelAmount = value; }
        
        private double FuelConsumptionFor1Km{ get => _fuelConsumptionFor1km; set => _fuelConsumptionFor1km = value; }

        private double TraveledDistance = 0;

        public void DriveCar(int amountOfKm)
        {
            double consumeFuel = amountOfKm * this.FuelConsumptionFor1Km;
            double leftFuel = this.FuelAmount - consumeFuel;
            if (leftFuel < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.FuelAmount = leftFuel;
            this.TraveledDistance += amountOfKm;
        }

        public override string ToString() => $"{Model} {FuelAmount:f2} {TraveledDistance}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                int fuelAmount = int.Parse(carInfo[1]);
                double fuelConsumptionFor1Km = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1Km);
                cars.Add(car);
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] line = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = line[1];
                int amountOfKm = int.Parse(line[2]);

                foreach (var car in cars)
                {
                    if (car.Model == carModel) car.DriveCar(amountOfKm);
                }

                input = Console.ReadLine();
            }
            
            cars.ForEach(Console.WriteLine);
        }
    }
}