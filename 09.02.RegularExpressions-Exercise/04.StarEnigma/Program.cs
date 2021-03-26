using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise._04.StarEnigma
{
    class Program
    {
        static void Main()
        {
            int messagesCount = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < messagesCount; i++)
            {
                string message = Console.ReadLine();

                int counter = message.Count(
                    x => x == 'S' || x == 's' || x == 'T' || x == 't' || x == 'A' || x == 'a' || x == 'R' || x == 'r');

                char[] decryptedChars = message.Select(ch => ch = (char)(ch - counter)).ToArray();

                string decryptedMessage = new string(decryptedChars);

                string pattern = @"@(?<name>[A-za-z]+)[^@!:>-]*:(?<population>\d+)[^@!:>-]*!(?<type>A|D)![^@!:>-]*->(?<count>\d+)";

                //MatchCollection validPlanets = Regex.Matches(decryptedMessage, pattern);

                //foreach (Match planet in validPlanets)
                //{
                //    if (planet.Groups["type"].Value == "A")
                //    {
                //        attackedPlanets.Add(planet.Groups["name"].Value);
                //    }
                //    else
                //    {
                //        destroyedPlanets.Add(planet.Groups["name"].Value);
                //    }
                //}

                Match match = Regex.Match(decryptedMessage, pattern);

                if (match.Success)
                {
                    string type = match.Groups["type"].Value;

                    if (type == "A")
                    {
                        attackedPlanets.Add(match.Groups["name"].Value);
                    }
                    else
                    {
                        destroyedPlanets.Add(match.Groups["name"].Value);
                    }
                }
            }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var name in attackedPlanets)
            {
                Console.WriteLine($"-> {name}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var name in destroyedPlanets)
            {
                Console.WriteLine($"-> {name}");
            }
        }
    }
}
