using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main()
        {
            int commandsCount = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string userName = commands[1];


                switch (commands[0])
                {
                    case "register":
                        string licensePlateNumber = commands[2];

                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, licensePlateNumber);
                            Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                        }
                        else 
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        break;

                    case "unregister":

                        if (!users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else 
                        {
                            Console.WriteLine($"{userName} unregistered successfully");
                            users.Remove(userName);
                        }
                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
