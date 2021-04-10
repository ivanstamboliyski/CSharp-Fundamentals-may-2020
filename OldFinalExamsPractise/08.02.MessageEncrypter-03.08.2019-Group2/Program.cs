using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08._02.MessageEncrypter_03._08._2019_Group2
{
    class Program
    {
        static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), @"(@|\*)(?<tag>[A-Z][a-z]{2,})\1: \[(?<one>[A-Za-z])\]\|\[(?<two>[A-Za-z])\]\|\[(?<three>[A-Za-z])\]\|$");

                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    Console.WriteLine($"{match.Groups["tag"]}: " + string.Join(" ", String.Concat(match.Groups["one"].Value, match.Groups["two"].Value, match.Groups["three"].Value).Select(x => (int)x).ToArray()));
                }
            }
        }
    }
}
