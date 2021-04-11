using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._03.MessagesManager_03._08._2019_Group1
{
    class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());

            string commands;

            Dictionary<string, User> userStats = new Dictionary<string, User>();

            while ((commands = Console.ReadLine()) != "Statistics")
            {
                string mainCommand = commands.Split("=")[0];

                switch (mainCommand)
                {
                    case "Add":
                        if (!userStats.ContainsKey(commands.Split("=")[1]))
                        {
                            userStats.Add(commands.Split("=")[1], new User(int.Parse(commands.Split("=")[2]), int.Parse(commands.Split("=")[3]), capacity));
                        }
                        break;

                    case "Message":
                        string sender = commands.Split("=")[1];
                        string receiver = commands.Split("=")[2];
                        if (userStats.ContainsKey(sender) && userStats.ContainsKey(receiver))
                        {
                            userStats[sender].SendMessages += 1;

                            if (userStats[sender].SendMessages + userStats[sender].ReceivedMessages >= userStats[sender].Capacity)
                            {
                                userStats.Remove(sender);
                                Console.WriteLine($"{sender} reached the capacity!");
                            }

                            userStats[receiver].ReceivedMessages += 1;

                            if (userStats[receiver].ReceivedMessages + userStats[receiver].SendMessages >= userStats[receiver].Capacity)
                            {
                                userStats.Remove(receiver);
                                Console.WriteLine($"{receiver} reached the capacity!");
                            }
                        }
                        break;

                    case "Empty":
                        if (commands.Split("=")[1] == "All")
                        {
                            userStats.Clear();
                        }
                        else if (userStats.ContainsKey(commands.Split("=")[1]))
                        {
                            userStats.Remove(commands.Split("=")[1]);
                        }
                        break;
                }
            }

            Console.WriteLine($"Users count: {userStats.Count}");

            foreach (var user in userStats.OrderByDescending(x => x.Value.ReceivedMessages).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value.ReceivedMessages + user.Value.SendMessages}");
            }
        }
    }
    class User
    {
        public int SendMessages { get; set; }
        public int ReceivedMessages { get; set; }
        public int Capacity { get; set; }

        public User(int send, int received, int capacity)
        {
            this.SendMessages = send;
            this.ReceivedMessages = received;
            this.Capacity = capacity;
        }
    }
}


