using System;
using System.Collections.Generic;
using System.Text;

namespace _03.SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TraveledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            TraveledDistance = 0;
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public void Moving(double distance)
        {
            double neededFuel = distance * this.FuelConsumptionPerKm;

            if (neededFuel > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.TraveledDistance += distance;
                this.FuelAmount -= neededFuel;
            }
        }
    }
}
