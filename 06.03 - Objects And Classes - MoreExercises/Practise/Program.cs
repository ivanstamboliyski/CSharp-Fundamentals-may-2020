using System;
using System.Collections.Generic;

namespace Practise
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0; //не е в конструктора, но е дефолтна
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumptionPerKilometer
        {
            get
            {
                return this.fuelConsumptionPerKilometer;
            }
            set
            {
                this.fuelConsumptionPerKilometer = value;
            }
        }

        public double TravelledDistance
        {
            get
            {
                return this.travelledDistance;
            }
            set
            {
                this.travelledDistance = value;
            }
        }

        public void CanDriveTheDistance(double amountOfKm)
        {

            double neededFuel = amountOfKm * this.FuelConsumptionPerKilometer;
            if (neededFuel <= this.FuelAmount)
            {
                this.FuelAmount -= neededFuel;
                this.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
