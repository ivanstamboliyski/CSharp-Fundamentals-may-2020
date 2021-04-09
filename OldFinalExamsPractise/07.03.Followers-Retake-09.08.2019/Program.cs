using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._03.Followers_Retake_09._08._2019
{
    class Program
    {
        static void Main()
        {
            string commands;

            Dictionary<string, Dictionary<string, int>> followersStats = new Dictionary<string, Dictionary<string, int>>(); 

            while ((commands = Console.ReadLine()) != "Log out")
            {
                string mainCommand = commands.Split(": ")[0];
                string username = commands.Split(": ")[1];

                switch (mainCommand)
                {
                    case "New follower":
                        if (!followersStats.ContainsKey(username))
                        {
                            followersStats.Add(username, new Dictionary<string, int>() { {"likes", 0 }, {"comments", 0 }});
                        }
                        break;

                    case "Like":
                        int likesCount = int.Parse(commands.Split(": ")[2]);
                        if (!followersStats.ContainsKey(username))
                        {
                            followersStats.Add(username, new Dictionary<string, int>() { { "likes", likesCount }, { "comments", 0 } });
                        }
                        else
                        {
                            followersStats[username]["likes"] += likesCount;
                        }
                        break;

                    case "Comment":
                        if (!followersStats.ContainsKey(username))
                        {
                            followersStats.Add(username, new Dictionary<string, int>() { { "likes", 0 }, { "comments", 1 } });
                        }
                        else
                        {
                            followersStats[username]["comments"] += 1;
                        }
                        break;

                    case "Blocked":
                        if (!followersStats.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} doesn't exist."); ;
                        }
                        else
                        {
                            followersStats.Remove(username);
                        }
                        break;
                }
            }

            Console.WriteLine($"{followersStats.Keys.Count} followers");

            foreach (var user in followersStats.OrderByDescending(x => x.Value["likes"]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value["likes"] + user.Value["comments"]}");
            }
        }
    }
}
