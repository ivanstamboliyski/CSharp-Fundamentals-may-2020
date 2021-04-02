using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _03._03.P_rates__04._04._2020_Group_1
{
    class Program
    {
        static void Main()
        {
            string cities;

            Dictionary<string, City> citiesStats = new Dictionary<string, City>();

            while ((cities = Console.ReadLine()) != "Sail") 
            {
                string cityName = cities.Split("||")[0];
                int population = int.Parse(cities.Split("||")[1]);
                int gold = int.Parse(cities.Split("||")[2]);

                if (!citiesStats.ContainsKey(cityName))
                {
                    citiesStats.Add(cityName, new City(population, gold));
                }
                else
                {
                    citiesStats[cityName].Population += population;
                    citiesStats[cityName].Gold += gold;
                }
            }

            string events;

            while ((events = Console.ReadLine()) != "End")
            {
                string currEvent = events.Split("=>")[0];
                string town = events.Split("=>")[1];

                if (currEvent == "Plunder")
                {
                    int people = int.Parse(events.Split("=>")[2]);
                    int gold = int.Parse(events.Split("=>")[3]);
                    citiesStats[town].Population -= people;
                    citiesStats[town].Gold -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (citiesStats[town].Population <= 0 || citiesStats[town].Gold <= 0)
                    {
                        citiesStats.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (currEvent == "Prosper")
                {
                    int gold = int.Parse(events.Split("=>")[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }

                    citiesStats[town].Gold += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citiesStats[town].Gold} gold.");
                }
            }

            if (citiesStats.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }

            Console.WriteLine($"Ahoy, Captain! There are {citiesStats.Count} wealthy settlements to go to:");

            foreach (var city in citiesStats.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
            }
        }
    }
    class City 
    {
        public int Population { get; set; }
        public int Gold { get; set; }

        public City(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }
    }
}
