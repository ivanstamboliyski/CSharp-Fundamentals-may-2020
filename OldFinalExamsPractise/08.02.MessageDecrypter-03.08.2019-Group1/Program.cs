using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _08._02.MessageDecrypter_03._08._2019_Group1
{
    class Program
    {
        static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), @"^(\$|%)(?<tag>[A-Z][a-z]{2,})\1: \[(?<one>[0-9]+)\]\|\[(?<two>[0-9]+)\]\|\[(?<three>[0-9]+)\]\|$");

                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    Console.WriteLine($"{match.Groups["tag"]}: " + (char)Convert.ToInt32(match.Groups["one"].Value) + (char)Convert.ToInt32(match.Groups["two"].Value) + (char)Convert.ToInt32(match.Groups["three"].Value));
                }
            }
        }
    }
}
