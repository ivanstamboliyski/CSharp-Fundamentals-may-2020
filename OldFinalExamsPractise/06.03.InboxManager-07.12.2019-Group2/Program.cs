using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._03.InboxManager_07._12._2019_Group2
{
    class Program
    {
        static void Main()
        {
            string commands;

            Dictionary<string, List<string>> usersStats = new Dictionary<string, List<string>>();

            while ((commands = Console.ReadLine()) != "Statistics")
            {
                string mainCommand = commands.Split("->")[0];

                switch (mainCommand)
                {
                    case"Add":
                        string username = commands.Split("->")[1];
                        if (usersStats.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} is already registered");
                        }
                        else
                        {
                            usersStats.Add(username, new List<string>());
                        }
                        break;

                    case "Send":
                        username = commands.Split("->")[1];
                    string email = commands.Split("->")[2];
                        usersStats[username].Add(email);
                        break;

                    case "Delete":
                        username = commands.Split("->")[1];
                        if (usersStats.ContainsKey(username))
                        {
                            usersStats.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} not found!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Users count: {usersStats.Keys.Count}");

            foreach (var user in usersStats.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");

                foreach (var email in user.Value)
                {
                    Console.WriteLine("- " + string.Join("", email));
                }
            }
        }
    }
}
