using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace _03._02.EmojiDetector__04._04._2020_Group_1
{
    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();

            string emojiPattern = @"(:{2}|\*{2})(?<core>[A-Z][a-z]{2,})\1";

            MatchCollection coolThresholdMatches = Regex.Matches(inputText, "[0-9]");

            int coolnesThreshold = coolThresholdMatches.Select(x => int.Parse(x.Value)).Aggregate(1, (x, y) => x * y);

            //int coolnesThreshold  = 1;

            //foreach (Match match in coolThresholdMatches)
            //{
            //    coolnesThreshold *= int.Parse(match.Value);
            //}

            MatchCollection emojiMatches = Regex.Matches(inputText, emojiPattern);

            Console.WriteLine($"Cool threshold: {coolnesThreshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojiMatches)
            {
                int emojiCoolness = emoji.Groups["core"].Value.Select(c => (int)c).Sum();

                if (emojiCoolness >= coolnesThreshold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }
    }
}
