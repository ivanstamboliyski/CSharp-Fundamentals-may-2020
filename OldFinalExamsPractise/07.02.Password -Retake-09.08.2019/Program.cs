using System;
using System.Text.RegularExpressions;

namespace _07._02.Password__Retake_09._08._2019
{
    class Program
    {
        static void Main()
        {
            int inputsCount = int.Parse(Console.ReadLine());

            for (int input = 0; input < inputsCount; input++)
            {
                string password = Console.ReadLine();

                string pattern = @"^(.+)>(?<one>[0-9]{3})\|(?<two>[a-z]{3})\|(?<three>[A-Z]{3})\|(?<four>[^<>]+)<(\1)$";

                Match match = Regex.Match(password, pattern);

                if (match.Success)
                {
                    string encryptedPassword = String.Concat(match.Groups["one"].Value, match.Groups["two"].Value, match.Groups["three"].Value, match.Groups["four"].Value);
                    Console.WriteLine($"Password: {encryptedPassword}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
