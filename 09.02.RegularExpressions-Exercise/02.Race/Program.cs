using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise._02.Race
{
    class Program
    {
        static void Main()
        {
            List<string> participants = Console.ReadLine().Split(", ").ToList();

            string namePattern = @"[A-Za-z]";
            string distancePattern = @"[0-9]";

            string inputInfo = "dbdbfdb";

            Dictionary<string, double> raceInfo = new Dictionary<string, double>();

            while ((inputInfo = Console.ReadLine()) != "end of race")
            {
                MatchCollection currPlayer = Regex.Matches(inputInfo, namePattern);
                MatchCollection currDistance = Regex.Matches(inputInfo, distancePattern);
                string playerName = String.Concat(currPlayer);
                double distance = currDistance.Select(s => double.Parse(s.Value)).Sum();

                if (participants.Contains(playerName))
                {
                    if (!raceInfo.ContainsKey(playerName))
                    {
                        raceInfo.Add(playerName, distance);
                    }
                    else
                    {
                        raceInfo[playerName] += distance;
                    }
                }
            }

            List<string> finalResult = raceInfo.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();

            Console.WriteLine($"1st place: {finalResult[0]}");
            Console.WriteLine($"2nd place: {finalResult[1]}");
            Console.WriteLine($"3rd place: {finalResult[2]}");
        }
    }
}
