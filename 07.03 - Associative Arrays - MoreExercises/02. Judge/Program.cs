using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Judge
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, Dictionary<string, int>> contestsList = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualStandings = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string username = input.Split(" -> ")[0];
                string contestName = input.Split(" -> ")[1];
                int points = int.Parse(input.Split(" -> ")[2]);
                bool newPoints = false;
                bool hasToAdd = false;
                int oldPoints = 0;

                if (!contestsList.ContainsKey(contestName))
                {
                    contestsList.Add(contestName, new Dictionary<string, int>());
                    contestsList[contestName].Add(username, points);
                    hasToAdd = true;
                }
                else if (contestsList[contestName].ContainsKey(username) && 
                         contestsList[contestName][username] < points)
                {
                    oldPoints = contestsList[contestName][username];
                    contestsList[contestName][username] = points;
                    hasToAdd = true;
                    newPoints = true;
                }
                else if (!contestsList[contestName].ContainsKey(username))
                {
                    contestsList[contestName].Add(username, points);
                    hasToAdd = true;
                }


                if (!individualStandings.ContainsKey(username) && hasToAdd)
                {
                    individualStandings.Add(username, points);
                }
                else if (!newPoints && hasToAdd)
                {
                    individualStandings[username] += points;
                }
                else if (hasToAdd)
                {
                    individualStandings[username] += points - oldPoints;
                }
            }

            int counter = 0;

            foreach (var contest in contestsList)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                counter = 1;

                foreach (var user in contest.Value.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
                {
                    Console.WriteLine($"{counter}. {user.Key} <::> {user.Value}");
                    counter++;
                }
            }

            counter = 1;
            Console.WriteLine("Individual standings:");

            foreach (var user in individualStandings.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
            {
                Console.WriteLine($"{counter}. {user.Key} -> {user.Value}");
                counter++;
            }
        }
    }
}
