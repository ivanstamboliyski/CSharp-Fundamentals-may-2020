using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._03.The_Isle_of_Man_TT_Race_Preparation_24._07._2019
{
    class Program
    {
        static void Main()
        {
            Regex pattern = new Regex(@"([#$%*&])(?<name>[A-Za-z]+)\1=(?<lenght>[0-9]+)!!(?<code>.+)$");

            while (true)
            {
                string message = Console.ReadLine();

                Match valid = pattern.Match(message);

                int codeLenght = valid.Groups["code"].Value.Length;

                if (!pattern.IsMatch(message))
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                int givenLenght = int.Parse(valid.Groups["lenght"].Value);

                if (codeLenght != givenLenght)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }

                var geohashCode = valid.Groups["code"].Value.ToCharArray().Select(x => x = (char)(x + givenLenght));

                Console.WriteLine($"Coordinates found! {valid.Groups["name"].Value} -> {string.Join("", geohashCode)}");
                break;
            }
        }
    }
}
