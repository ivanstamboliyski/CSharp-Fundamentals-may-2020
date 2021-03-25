using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Lab_01.MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string regex = @"[+]359( |-)2\1\d{3}\1\d{4}\b";

            string phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
