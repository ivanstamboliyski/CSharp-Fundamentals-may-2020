using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Lab_03.MatchDates
{
    class Program
    {
        static void Main()
        {
            string regex = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string datesString = Console.ReadLine();

            MatchCollection matchedDates = Regex.Matches(datesString, regex);

            foreach (Match date in matchedDates)
            {
                string day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }
        }
    }
}
