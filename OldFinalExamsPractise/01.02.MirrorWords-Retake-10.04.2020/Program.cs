using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._02.MirrorWords_Retake_10._04._2020
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string hiddenPairsPattern = @"([@|#])(?<wordOne>[a-zA-z]{3,})(\1)(\1)(?<wordTwo>[a-zA-z]{3,})(\1)";

            MatchCollection validWords = Regex.Matches(input, hiddenPairsPattern);

            if (validWords.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{validWords.Count} word pairs found!");
            }

            List<string> mirrorWords = new List<string>();

            foreach (Match pair in validWords)
            {
                string firstWord = pair.Groups["wordOne"].Value;
                string secondWord = pair.Groups["wordTwo"].Value;
                string secondWordReversed = String.Concat(secondWord.Reverse());

                if (firstWord == secondWordReversed)
                {
                    mirrorWords.Add(firstWord + " <=> " + secondWord);
                }
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");

                Console.WriteLine(string.Join(", ", mirrorWords));
            }
        }
    }
}
