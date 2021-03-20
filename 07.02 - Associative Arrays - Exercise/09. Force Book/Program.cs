using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.ForceBook
{
    class Program
    {
        static void Main()
        {
            //// The key is the forceSide

            //string input;

            //Dictionary<string, List<string>> sidesWithUsers = new Dictionary<string, List<string>>();

            //while ((input = Console.ReadLine()) != "Lumpawaroo")
            //{
            //    if (input.Contains("|"))
            //    {
            //        string forceSide = input.Split(" | ")[0];
            //        string forceUser = input.Split(" | ")[1];
            //        bool exist = false;

            //        if (sidesWithUsers.ContainsKey(forceSide))
            //        {
            //            foreach (var usersList in sidesWithUsers.Values)
            //            {
            //                if (usersList.Contains(forceUser))
            //                {
            //                    exist = true;
            //                    break;
            //                }
            //            }

            //            if (!exist)
            //            {
            //                sidesWithUsers[forceSide].Add(forceUser);
            //            }
            //        }
            //        else
            //        {
            //            foreach (var usersList in sidesWithUsers.Values)
            //            {
            //                if (usersList.Contains(forceUser))
            //                {
            //                    exist = true;
            //                    break;
            //                }
            //            }

            //            if (!exist)
            //            {
            //                sidesWithUsers.Add(forceSide, new List<string>());
            //                sidesWithUsers[forceSide].Add(forceUser);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        string forceSide = input.Split(" -> ")[1];
            //        string forceUser = input.Split(" -> ")[0];
            //        bool exist = false;

            //        if (sidesWithUsers.ContainsKey(forceSide))
            //        {
            //            foreach (var usersList in sidesWithUsers.Values)
            //            {
            //                if (usersList.Contains(forceUser))
            //                {
            //                    sidesWithUsers[forceSide].Add(forceUser);
            //                    usersList.Remove(forceUser);
            //                    exist = true;
            //                    break;
            //                }
            //            }

            //            if (!exist)
            //            {
            //                sidesWithUsers[forceSide].Add(forceUser);
            //            }
            //        }
            //        else
            //        {
            //            sidesWithUsers.Add(forceSide, new List<string>());

            //            foreach (var usersList in sidesWithUsers.Values)
            //            {
            //                if (usersList.Contains(forceUser))
            //                {
            //                    usersList.Remove(forceUser);
            //                    sidesWithUsers[forceSide].Add(forceUser);
            //                    exist = true;
            //                    break;
            //                }
            //            }

            //            if (!exist)
            //            {
            //                sidesWithUsers[forceSide].Add(forceUser);
            //            }
            //        }

            //        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            //    }
            //}

            //foreach (var side in sidesWithUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            //{
            //    if (side.Value.Count > 0)
            //    {
            //        Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

            //        foreach (var user in side.Value.OrderBy(x => x))
            //        {
            //            Console.WriteLine($"! {user}");
            //        }*
            //    }
            //}




            //// The key is the forceUser

            Dictionary<string, string> forceUsers = new Dictionary<string, string>();

            string command = null;

            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                var test = command.Split();

                if (test.Contains("|"))
                {
                    string[] commandArr = command.Split(" | ");
                    string forceSide = commandArr[0];
                    string forceUser = commandArr[1];

                    if (!forceUsers.ContainsKey(forceUser)) 
                    {
                        forceUsers.Add(forceUser, forceSide);
                    }
                }
                else if (test.Contains("->"))
                {
                    string[] commandArr = command.Split(" -> ");
                    string forceUser = commandArr[0];
                    string forceSide = commandArr[1];

                    if (forceUsers.ContainsKey(forceUser)) 
                    {
                        forceUsers[forceUser] = forceSide;
                    }
                    else
                    {
                        forceUsers.Add(forceUser, forceSide);
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            foreach (var users in forceUsers
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(c => c.Key))
            {
                Console.WriteLine($"Side: {users.Key}, Members: {users.Count()}");

                foreach (var elm in users.OrderBy(t => t.Key))
                {
                    Console.WriteLine($"! {elm.Key}");
                }
            }
        }
    }
}
