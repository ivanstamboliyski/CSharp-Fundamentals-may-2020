using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondPlayerCards[0]);
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);

                }
                else if (secondPlayerCards[0] > firstPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(firstPlayerCards[0]);
                    secondPlayerCards.RemoveAt(0);
                    firstPlayerCards.RemoveAt(0);
                }
                else
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
            }

            int sum = 0;

            if (firstPlayerCards.Count == 0)
            {
                foreach (var num in secondPlayerCards)
                {
                    sum += num;
                }

                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                foreach (var num in firstPlayerCards)
                {
                    sum += num;
                }

                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
