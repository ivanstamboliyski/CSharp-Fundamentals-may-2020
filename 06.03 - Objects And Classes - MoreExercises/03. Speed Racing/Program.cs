using System;
using System.Collections.Generic;

namespace _03.SpeedRacing
{
    class Program
    {
        static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine( ));

            Dictionary<string, Car> carsStats = new Dictionary<string, Car>();

            for (int currCar = 0; currCar < carsCount; currCar++)
            {
                string[] carInfo = Console.ReadLine().Split();

                Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));

                carsStats.Add(carInfo[0], car);
            }

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string carModel = commands.Split()[1];
                double amountOfKm = double.Parse(commands.Split()[2]);

                carsStats[carModel].Moving(amountOfKm);
            }

            foreach (var car in carsStats)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:f2} {car.Value.TraveledDistance}");
            }
        }
    }
    //class Car 
    //{
    //    public string Model { get; set; }
    //    public double FuelAmount { get; set; }
    //    public double FuelConsumptionPerKm { get; set; }
    //    public double TraveledDistance { get; set; }

    //    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    //    {
    //        TraveledDistance = 0;
    //        this.Model = model;
    //        this.FuelAmount = fuelAmount;
    //        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    //    }

    //    public void Moving(double distance) 
    //    {
    //        double neededFuel = distance * this.FuelConsumptionPerKm;

    //        if (neededFuel > this.FuelAmount)
    //        {
    //            Console.WriteLine("Insufficient fuel for the drive");
    //        }
    //        else
    //        {
    //            this.TraveledDistance += distance;
    //            this.FuelAmount -= neededFuel;
    //        }
    //    }
    
}


