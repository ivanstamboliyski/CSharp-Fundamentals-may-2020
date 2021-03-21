using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int dragonsNumber = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, Dragon>> dragonsCollection = new Dictionary<string, Dictionary<string, Dragon>>();

            for (int dragon = 1; dragon <= dragonsNumber; dragon++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string type = inputInfo[0];
                string name = inputInfo[1];
                string damage = inputInfo[2];
                string health = inputInfo[3];
                string armor = inputInfo[4];

                Dragon currDragon = new Dragon(damage, health, armor);

                if (!dragonsCollection.ContainsKey(type))
                {
                    dragonsCollection.Add(type, new Dictionary<string, Dragon>());
                    dragonsCollection[type].Add(name, currDragon);
                }
                else
                {
                    if (!dragonsCollection[type].ContainsKey(name))
                    {
                        dragonsCollection[type].Add(name, currDragon);
                    }
                    else
                    {
                        dragonsCollection[type][name] = currDragon;
                    }
                }
            }

            foreach (var type in dragonsCollection)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Values.Average(x => x.Damage):f2}/{type.Value.Values.Average(x => x.Health):f2}/{type.Value.Values.Average(x => x.Armor):f2})");

                foreach (var name in type.Value.OrderBy(d => d.Key))
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value.Damage}, health: {name.Value.Health}, armor: {name.Value.Armor}");
                }
            }
        }
        class Dragon
        {
            public int Damage { get; set; }
            public int Health { get; set; }
            public int Armor { get; set; }

            public Dragon(string damage, string health, string armor)
            {
                Damage = damage == "null" ? 45 : int.Parse(damage);
                Health = health == "null" ? 250 : int.Parse(health);
                Armor = armor == "null" ? 10 : int.Parse(armor);
            }
        }
    }
}
