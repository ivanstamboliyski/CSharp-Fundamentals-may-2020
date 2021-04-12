using System;
using System.Linq;
using System.Collections.Generic;


namespace _10._01.Concert_Preparation_24._07._2019
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, List<string>> bandsMembers = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandsSceneTime = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] commands = input.Split("; ");
                string mainCommand = commands[0];
                string bandName = commands[1];

                switch (mainCommand)
                {
                    case "Add":
                       List<string> members = commands[2].Split(", ").ToList();

                        if (!bandsMembers.ContainsKey(bandName))
                        {
                            bandsMembers.Add(bandName, new List<string>());
                            bandsMembers[bandName] = members;
                        }
                        else
                        {
                            members = members.Where(x => !bandsMembers[bandName].Contains(x)).ToList();
                            bandsMembers[bandName].AddRange(members);
                        }
                        break;

                    case "Play":
                        int time = int.Parse(commands[2]);

                        if (!bandsSceneTime.ContainsKey(bandName))
                        {
                            bandsSceneTime.Add(bandName, time);
                        }
                        else
                        {
                            bandsSceneTime[bandName] += time;
                        }
                        break;
                }
            }

            int totalTime = bandsSceneTime.Values.Sum();
            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandsSceneTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string bandToPrint = Console.ReadLine();
            Console.WriteLine(bandToPrint);

            foreach (var member in bandsMembers[bandToPrint])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
