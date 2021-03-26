using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise._06.ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=\s)\b([a-z]+|[0-9]+)[._-]*([a-z]+|[0-9])+@[a-z-]+\.[a-z.]+\b";

            MatchCollection validEmails = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(Environment.NewLine, validEmails));
        }
    }
}
