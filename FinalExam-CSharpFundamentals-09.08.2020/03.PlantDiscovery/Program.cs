using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main()
        {
            int plantsNumber = int.Parse(Console.ReadLine());

            List<Plant> plants = new List<Plant>();

            for (int currPlant = 0; currPlant < plantsNumber; currPlant++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = input[0].Trim();
                int plantRarity = int.Parse(input[1].Trim());

                var searchedPlant = plants.Find(x => x.Name == plantName);


                if (searchedPlant == null)
                {
                    Plant plant = new Plant(plantName, plantRarity, 0);
                    plants.Add(plant);
                }
                else
                {
                    searchedPlant.Rarity = plantRarity;
                }
            }

            string commands;

            while ((commands = Console.ReadLine()) != "Exhibition")
            {
                string[] currCommands = commands.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string mainCommand = currCommands[0].Trim();
                string plantName = currCommands[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries)[0].Trim();

                var searchedPlant = plants.Find(x => x.Name == plantName);

                switch (mainCommand)
                {
                    case "Rate":
                        if (!plants.Contains(searchedPlant) || mainCommand != "Rate")
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            int plantRating = int.Parse(currCommands[1].Split(" - ")[1]);
                            searchedPlant.AllRatings.Add(plantRating);
                        }
                        break;

                    case "Update":
                        if (!plants.Contains(searchedPlant) || mainCommand != "Update")
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            int rarity = int.Parse(currCommands[1].Split(" - ")[1]);
                            searchedPlant.Rarity = rarity;
                        }
                        break;

                    case "Reset":
                        if (!plants.Contains(searchedPlant) || mainCommand != "Reset")
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            searchedPlant.AllRatings.Clear();
                        }
                        break;
                }
            }

            foreach (var plant in plants)
            {
                if (plant.AllRatings.Count == 0)
                {
                    plant.AllRatings.Add(0);
                }
            }

            Console.WriteLine($"Plants for the exhibition:");

            foreach (var plant in plants.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.AllRatings.Average()))
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.AllRatings.Average():f2}");
            }
        }
    }
    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public int Rating { get; set; }
        public List<int> AllRatings { get; set; }

        public Plant(string name, int rarity, int rating)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.Rating = rating;
            AllRatings = new List<int>();
        }
    }
}
