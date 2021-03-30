using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main()
        {
            string locations = Console.ReadLine();

            string pattern = @"(=|\/)(?<place>[A-Z][A-Za-z]{2,})\1";

            MatchCollection validDestinations = Regex.Matches(locations, pattern);
            List<string> finalInput = new List<string>();

            int travelPoints = 0;

            foreach (Match location in validDestinations)
            {
                travelPoints += location.Groups["place"].Length;
                finalInput.Add(location.Groups["place"].Value);
            }

            Console.WriteLine($"Destinations: " + string.Join(", ", finalInput));
            Console.WriteLine($"Travel Points: {travelPoints}");

            double[]
        }
    }
}
