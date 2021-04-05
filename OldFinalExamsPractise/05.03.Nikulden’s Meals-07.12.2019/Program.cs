using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._03.Nikulden_s_Meals_07._12._2019
{
    class Program
    {
        static void Main()
        {
            string input;
            int unlikedMeals = 0;

            Dictionary<string, List<string>> guestsMeals = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "Stop")
            {
                string command = input.Split("-")[0];
                string guest = input.Split("-")[1];
                string meal = input.Split("-")[2];

                if (command == "Like")
                {
                    if (!guestsMeals.ContainsKey(guest))
                    {
                        guestsMeals.Add(guest, new List<string>() {meal});
                    }
                    else if (!guestsMeals[guest].Contains(meal))
                    {
                        guestsMeals[guest].Add(meal);
                    }
                }
                else if (command == "Unlike")
                {
                    if (!guestsMeals.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!guestsMeals[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        guestsMeals[guest].Remove(meal);
                        unlikedMeals++;
                    }
                }
            }

            foreach (var guest in guestsMeals.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{guest.Key}: " + string.Join(", ", guest.Value));
            }

            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
