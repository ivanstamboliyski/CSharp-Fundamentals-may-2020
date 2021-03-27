using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MoreExercise._01.WinningTicket
{
    class Program
    {
        static void Main()
        {
            string[] tickets = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tickets.Length; i++)
            {
                string currTicket = tickets[i].Trim();

                if (currTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftHalf = currTicket.Substring(0,10);
                string rightHalf = currTicket.Substring(10,10);

                string pattern = @"[$]{6,10}|[#]{6,10}|[\^]{6,10}|[@]{6,10}";

                Match leftSide = Regex.Match(leftHalf, pattern);
                Match rightSide = Regex.Match(rightHalf, pattern);

                if (leftSide.Success && rightSide.Success)
                {
                    char winningSymbol = currTicket.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                    double leftHalfOccurences = leftHalf.Count(x => x == winningSymbol);
                    double rightHalfOccurences = rightHalf.Count(x => x == winningSymbol);

                    if (leftHalfOccurences == 10 && rightHalfOccurences == 10)
                    {
                        Console.WriteLine($"ticket \"{currTicket}\" - {rightHalfOccurences}{winningSymbol} Jackpot!");
                    }
                    else 
                    {
                        Console.WriteLine($"ticket \"{currTicket}\" - {Math.Min(leftHalfOccurences, rightHalfOccurences)}{winningSymbol}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{currTicket}\" - no match");
                }
            }
        }
    }
}
