using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            string[] inputData = Console.ReadLine().Split();
            List<Vehicle> vehicles = new List<Vehicle>();

            while (inputData[0] != "End")
            {
                Vehicle catalog = new Vehicle(inputData[0], inputData[1], inputData[2], double.Parse(inputData[3]));

                vehicles.Add(catalog);

                inputData = Console.ReadLine().Split();
            }

            string currModel = string.Empty;

            while ((currModel = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(v => v.Model == currModel));
            }


            List<Vehicle> cars = vehicles.FindAll(v => v.Type == "Car");
            double carsHorsePowerSum = cars.Sum(c => c.HorsePower);

            List<Vehicle> trucks = vehicles.FindAll(v => v.Type == "Truck");
            double trucksHorsePowerSum = trucks.Sum(t => t.HorsePower);


            double averageCarsPower = carsHorsePowerSum / cars.Count;
            double averageTrucksPower = trucksHorsePowerSum / trucks.Count;

            if (cars.Count == 0)
            {
                averageCarsPower = 0;
            }
            if (trucks.Count == 0)
            {
                averageTrucksPower = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarsPower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksPower:F2}.");
        }
        class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicle(string type, string model, string color, double horsePower)
            {
                if (type == "car")
                {
                    Type = "Car";
                }
                else
                {
                    Type = "Truck";
                }

                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            public override string ToString()
            {
                StringBuilder result = new StringBuilder();

                result.AppendLine($"Type: {Type}");
                result.AppendLine($"Model: {Model}");
                result.AppendLine($"Color: {Color}");
                result.AppendLine($"Horsepower: {HorsePower}");

                return result.ToString().TrimEnd();
            }
        }
    }
}
