using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._03.BattleManager_03._08._2019_Group2
{
    class Program
    {
        static void Main()
        {
            string commands;

            Dictionary<string, Person> personsStats = new Dictionary<string, Person>();

            while ((commands = Console.ReadLine()) != "Results")
            {
                string mainCommand = commands.Split(":")[0];

                switch (mainCommand)
                {
                    case "Add":
                        if (!personsStats.ContainsKey(commands.Split(":")[1]))
                        {
                            personsStats.Add(commands.Split(":")[1], new Person(commands.Split(":")[1], int.Parse(commands.Split(":")[2]), int.Parse(commands.Split(":")[3])));
                        }
                        else
                        {
                            personsStats[commands.Split(":")[1]].Health += int.Parse(commands.Split(":")[2]);
                        }
                        break;

                    case "Attack":
                        string attackerName = commands.Split(":")[1];
                        string defenderName = commands.Split(":")[2];
                        int damage = int.Parse(commands.Split(":")[3]);
                        if (personsStats.ContainsKey(attackerName) && personsStats.ContainsKey(defenderName))
                        {
                            personsStats[defenderName].Health -= damage;

                            if (personsStats[defenderName].Health <= 0)
                            {
                                personsStats.Remove(defenderName);
                                Console.WriteLine($"{defenderName} was disqualified!");
                            }

                            personsStats[attackerName].Energy -= 1;

                            if (personsStats[attackerName].Energy <= 0)
                            {
                                personsStats.Remove(attackerName);
                                Console.WriteLine($"{attackerName} was disqualified!");
                            }
                        }
                        break;

                    case "Delete":
                        if (commands.Split(":")[1] == "All")
                        {
                            personsStats.Clear();
                        }
                        else if (personsStats.ContainsKey(commands.Split(":")[1]))
                        {
                            personsStats.Remove(commands.Split(":")[1]);
                        }
                        break;
                }
            }

            Console.WriteLine($"People count: {personsStats.Count}");

            foreach (var person in personsStats.OrderByDescending(x => x.Value.Health).ThenBy(x => x.Value.Name))
            {
                Console.WriteLine($"{person.Value.Name} - {person.Value.Health} - {person.Value.Energy}");
            }
        }
    }
    class Person 
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }

        public Person(string name, int health, int energy)
        {
            this.Name = name;
            this.Health = health;
            this.Energy = energy;
        }
    }
}
