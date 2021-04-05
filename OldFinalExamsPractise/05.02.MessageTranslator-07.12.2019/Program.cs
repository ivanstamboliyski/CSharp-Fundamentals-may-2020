using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._02.MessageTranslator_07._12._2019
{
    class Program
    {
        static void Main()
        {
            int messagesCount = int.Parse(Console.ReadLine());

            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[a-zA-Z]{8,})\]";

            for (int message = 0; message < messagesCount; message++)
            {
                string currMessage = Console.ReadLine();

                Match match = Regex.Match(currMessage, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    var encryptedMessage = String.Concat(match.Groups["message"].Value).Select(x => (int)x).ToArray();
                    Console.WriteLine($"{match.Groups["command"].Value}: " + string.Join(" ", encryptedMessage));
                }
            }
        }
    }
}
