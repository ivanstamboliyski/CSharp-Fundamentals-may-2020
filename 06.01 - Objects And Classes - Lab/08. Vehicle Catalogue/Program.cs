using System;
using System.Linq;
using System.Collections.Generic;
 
namespace _08_Lab_Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            string[] inputData = Console.ReadLine().Split("/");
            Catalog catalog = new Catalog();

            catalog.cars = new List<Car>();
            catalog.trucks = new List<Truck>();

            while (inputData[0] != "end")
            {
                if (inputData[0] == "Truck")
                {
                    catalog.trucks.Add(new Truck(inputData));
                }
                else
                {
                    catalog.cars.Add(new Car(inputData));
                }


                inputData = Console.ReadLine().Split("/");
            }

            if (catalog.cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.trucks.Count > 0 )
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Truck 
    {
        public Truck(string[] inputData)
        {
            Brand = inputData[1];
            Model = inputData[2];
            Weight = double.Parse(inputData[3]);
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    class Car
    {
        public Car(string[] inputData) 
        {
            Brand = inputData[1];
            Model = inputData[2];
            HorsePower = double.Parse(inputData[3]);
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }
    }
    class Catalog 
    {
        public List<Truck> trucks { get; set; }
        public List<Car> cars { get; set; }
    }
}