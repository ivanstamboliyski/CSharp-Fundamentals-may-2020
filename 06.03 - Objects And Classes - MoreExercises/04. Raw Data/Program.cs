using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    class Program
    {
        static void Main()
        {
            int carsCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int currCar = 0; currCar < carsCount; currCar++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Car car = new Car(model, engineSpeed, enginePower, cargoType, cargoWeight);

                cars.Add(car);
            }

            if (Console.ReadLine() == "fragile")
            {
                var sortedCars = cars.Where(c => c.cargo.Type == "fragile" && c.cargo.Weight < 1000).Select(c => c.Model).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, sortedCars));
            }
            else
            {
                var sortedCars = cars.Where(c => c.cargo.Type == "flamable" && c.engine.Power > 250).Select(c => c.Model).ToList();
                Console.WriteLine(string.Join(Environment.NewLine, sortedCars));
            }
        }
    }
    class Car 
    {
        public string Model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }

        public Car(string model, int speed, int power, string type, int weight)
        {
            this.Model = model;
            this.engine = new Engine(speed, power);
            this.cargo = new Cargo(type, weight);
        }
    }
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }
    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }
}
