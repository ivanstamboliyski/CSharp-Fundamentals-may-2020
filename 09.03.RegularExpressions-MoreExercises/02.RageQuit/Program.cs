using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace MoreExercise._02.RageQuit
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToUpper();

            string pattern = @"(([^\d]+)(\d+))";

            var matches = Regex.Matches(text, pattern);

            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                string temp = match.Groups[2].Value;

                int repeats = int.Parse(match.Groups[3].Value);

                result.AppendJoin(match.Groups[2].Value, new string[repeats + 1]);
            }

            int count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");

            Console.WriteLine(result);
        }
    }
}
