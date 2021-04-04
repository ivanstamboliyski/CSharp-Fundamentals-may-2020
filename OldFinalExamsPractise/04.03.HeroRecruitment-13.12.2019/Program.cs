using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._03.HeroRecruitment_13._12._2019
{
    class Program
    {
        static void Main()
        {
            string commands;

            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while ((commands = Console.ReadLine()) != "End")
            {
                string mainCommand = commands.Split()[0];
                string heroName = commands.Split()[1];

                switch (mainCommand)
                {
                    case "Enroll":
                        if (!heroes.ContainsKey(heroName))
                        {
                            heroes.Add(heroName, new List<string>());
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} is already enrolled.");
                        }
                        break;

                    case "Learn":
                        string spellName = commands.Split()[2];

                        if (!heroes.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else if (heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Add(spellName);
                        }
                        break;

                    case "Unlearn":
                        spellName = commands.Split()[2];

                        if (!heroes.ContainsKey(heroName))
                        {
                            Console.WriteLine($"{heroName} doesn't exist.");
                        }
                        else if (!heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Remove(spellName);
                        }
                        break;
                }
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in heroes.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"== {hero.Key}: " + string.Join(", ", hero.Value));
            }
        }
    }
}
