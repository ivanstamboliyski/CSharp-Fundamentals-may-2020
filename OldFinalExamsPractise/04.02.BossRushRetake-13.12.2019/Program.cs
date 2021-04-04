using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._02.BossRushRetake_13._12._2019
{
    class Program
    {
        static void Main()
        {
            int inputsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputsCount; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"\|(?<name>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";

                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("Access denied!");
                }
                else
                {
                    Console.WriteLine($"{match.Groups["name"].Value}, The {match.Groups["title"].Value}");
                    Console.WriteLine($">> Strength: {match.Groups["name"].Length}");
                    Console.WriteLine($">> Armour: {match.Groups["title"].Length}");
                }
            }
        }
    }
}
