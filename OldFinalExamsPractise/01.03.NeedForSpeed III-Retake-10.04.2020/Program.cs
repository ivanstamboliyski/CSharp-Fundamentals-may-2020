using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._03.NeedForSpeed_III_Retake_10._04._2020
{
    class Program
    {
        static void Main()
        {

            // SOLUTION WITH NESTED DICTIONARIES 

            int carsCount = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> carsData = new Dictionary<string, Dictionary<string, int>>();

            for (int car = 0; car < carsCount; car++)
            {
                string[] currCarInfo = Console.ReadLine().Split("|");
                string carName = currCarInfo[0];
                int mileage = int.Parse(currCarInfo[1]);
                int fuel = int.Parse(currCarInfo[2]);

                carsData.Add(carName, new Dictionary<string, int>());
                carsData[carName].Add("mileage", mileage);
                carsData[carName].Add("fuel", fuel);
            }

            string commands;

            while ((commands = Console.ReadLine()) != "Stop")
            {
                string carName = commands.Split(" : ")[1];

                switch (commands.Split(" : ")[0])
                {
                    case "Drive":
                        int distance = int.Parse(commands.Split(" : ")[2]);
                        int fuel = int.Parse(commands.Split(" : ")[3]);

                        if (carsData[carName]["fuel"] < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            carsData[carName]["mileage"] += distance;
                            carsData[carName]["fuel"] -= fuel;

                            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                            if (carsData[carName]["mileage"] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {carName}!");
                                carsData.Remove(carName);
                            }
                        }
                        break;

                    case "Refuel":
                        fuel = int.Parse(commands.Split(" : ")[2]);

                        if (carsData[carName]["fuel"] + fuel > 75)
                        {
                            fuel = 75 - carsData[carName]["fuel"];
                        }

                        carsData[carName]["fuel"] += fuel;

                        Console.WriteLine($"{carName} refueled with {fuel} liters");
                        break;

                    case "Revert":
                        int kilometers = int.Parse(commands.Split(" : ")[2]);

                        if (carsData[carName]["mileage"] - kilometers < 10000)
                        {
                            carsData[carName]["mileage"] = 10000;
                            continue;
                        }

                        carsData[carName]["mileage"] -= kilometers;
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                        break;
                }
            }

            foreach (var carInfo in carsData.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{carInfo.Key} -> Mileage: {carInfo.Value["mileage"]} kms, Fuel in the tank: {carInfo.Value["fuel"]} lt.");
            }



            //    // SOLUTION WITHCLASSES 

            //    int carsCount = int.Parse(Console.ReadLine());

            //    Dictionary<string, Car> carsData = new Dictionary<string, Car>();

            //    for (int car = 0; car < carsCount; car++)
            //    {
            //        string[] currCarInfo = Console.ReadLine().Split("|");
            //        string carName = currCarInfo[0];
            //        int mileage = int.Parse(currCarInfo[1]);
            //        int fuel = int.Parse(currCarInfo[2]);

            //        carsData.Add(carName, new Car(mileage, fuel));
            //    }

            //    string commands;

            //    while ((commands = Console.ReadLine()) != "Stop")
            //    {
            //        string command = commands.Split(" : ")[0];
            //        string carName = commands.Split(" : ")[1];


            //        switch (command)
            //        {
            //            case "Drive":
            //                int distance = int.Parse(commands.Split(" : ")[2]);
            //                int fuel = int.Parse(commands.Split(" : ")[3]);

            //                if (carsData[carName].Fuel < fuel)
            //                {
            //                    Console.WriteLine("Not enough fuel to make that ride");
            //                }
            //                else
            //                {
            //                    carsData[carName].Mileage += distance;
            //                    carsData[carName].Fuel -= fuel;

            //                    Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            //                    if (carsData[carName].Mileage >= 100000)
            //                    {
            //                        Console.WriteLine($"Time to sell the {carName}!");
            //                        carsData.Remove(carName);
            //                    }
            //                }
            //                break;

            //            case "Refuel":
            //                fuel = int.Parse(commands.Split(" : ")[2]);

            //                if (carsData[carName].Fuel + fuel > 75)
            //                {
            //                    fuel = 75 - carsData[carName].Fuel;
            //                }

            //                carsData[carName].Fuel += fuel;
            //                Console.WriteLine($"{carName} refueled with {fuel} liters");
            //                break;

            //            case "Revert":
            //                int kilometers = int.Parse(commands.Split(" : ")[2]);

            //                if (carsData[carName].Mileage - kilometers < 10000)
            //                {
            //                    carsData[carName].Mileage = 10000;
            //                    continue;
            //                }

            //                carsData[carName].Mileage -= kilometers;
            //                Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers"); 
            //                break;
            //        }
            //    }

            //    foreach (var car in carsData.OrderByDescending(x => x.Value.Mileage).ThenBy(x => x.Key))
            //    {
            //        Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            //    }
            //}

            //class Car
            //{
            //    public int Mileage { get; set; }
            //    public int Fuel { get; set; }

            //    public Car(int mileage, int fuel)
            //    {
            //        this.Mileage = mileage;
            //        this.Fuel = fuel;
            //    }
            //}
        }
}
