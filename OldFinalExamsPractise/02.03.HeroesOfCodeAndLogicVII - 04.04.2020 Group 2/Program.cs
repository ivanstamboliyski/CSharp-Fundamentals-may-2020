using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._03.HeroesOfCodeAndLogicVII___04._04._2020_Group_2
{
    class Program
    {
        static void Main()
        {
            int heroesCount = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> herosActions = new Dictionary<string, Dictionary<string, int>>();

            for (int hero = 0; hero < heroesCount; hero++)
            {
                string[] heroeStats = Console.ReadLine().Split();
                string heroName = heroeStats[0];
                int heroHitPoints = int.Parse(heroeStats[1]);
                int heroManaPoints = int.Parse(heroeStats[2]);

                herosActions.Add(heroName, new Dictionary<string, int>()
                {
                    { "hitPoints", heroHitPoints },
                    { "manaPoints", heroManaPoints }
                }); 
            }

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string command = commands.Split(" - ")[0];
                string heroName = commands.Split(" - ")[1];

                switch (command)
                {
                    case "CastSpell":
                        int manaPointsNeeded = int.Parse(commands.Split(" - ")[2]);
                        string spellName = commands.Split(" - ")[3];

                        if (herosActions[heroName]["manaPoints"] < manaPointsNeeded)
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        else
                        {
                            herosActions[heroName]["manaPoints"] -= manaPointsNeeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {herosActions[heroName]["manaPoints"]} MP!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(commands.Split(" - ")[2]);
                        string attacker = commands.Split(" - ")[3];

                        if (herosActions[heroName]["hitPoints"] - damage <= 0)
                        {
                            herosActions.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        else
                        {
                            herosActions[heroName]["hitPoints"] -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {herosActions[heroName]["hitPoints"]} HP left!");
                        }
                        break;

                    case "Recharge":
                        int amount = int.Parse(commands.Split(" - ")[2]);

                        if (herosActions[heroName]["manaPoints"] + amount > 200)
                        {
                            amount = 200 - herosActions[heroName]["manaPoints"];
                        }
                        herosActions[heroName]["manaPoints"] += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        break;

                    case "Heal":
                        amount = int.Parse(commands.Split(" - ")[2]);

                        if (herosActions[heroName]["hitPoints"] + amount > 100)
                        {
                            amount = 100 - herosActions[heroName]["hitPoints"];
                        }
                        herosActions[heroName]["hitPoints"] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        break;
                }
            }

            foreach (var hero in herosActions.OrderByDescending(x => x.Value["hitPoints"]).ThenBy(x => x.Key))
            {
                Console.WriteLine(hero.Key);

                Console.WriteLine($"  HP: {hero.Value["hitPoints"]}");
                Console.WriteLine($"  MP: {hero.Value["manaPoints"]}");
            }
        }
    }
}
