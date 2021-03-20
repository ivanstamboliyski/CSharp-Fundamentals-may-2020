using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._2.CSharpFundamentals_AssociativeArrays_Exercise
{
    class Program
    {
        static void Main()
        {

		METHOD 1

            //string[] words = Console.ReadLine().Split().ToArray();

            //var charsCount = new Dictionary<char, int>();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    for (int j = 0; j < words[i].Length; j++)
            //    {
            //        if (!charsCount.ContainsKey(words[i][j]))
            //        {
            //            charsCount[words[i][j]] = 1;
            //        }
            //        else
            //        {
            //            charsCount[words[i][j]]++;
            //        }
            //    }
            //}

            //foreach (var symbol in charsCount)
            //{
            //    Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            //}


		METHOD 2

            //string input = Console.ReadLine();

            //List<char> uniqueSymbols = input.Distinct().Where(c => c != ' ').ToList();

            //foreach (char symbol in uniqueSymbols)
            //{
            //    int currSymbolCount = input
            //        .Where(s => s == symbol)
            //        .Count();

            //    Console.WriteLine($"{symbol} -> {currSymbolCount}");
            //}

		
		METHOD 3

            string inputText = Console.ReadLine();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            for (int i = 0; i < inputText.Length; i++)
            {
                char symbol = inputText[i];

                if (symbol == ' ')
                {
                    continue;
                }

                if (charsCount.ContainsKey(symbol))
                {
                    charsCount[symbol]++;
                }
                else
                {
                    charsCount[symbol] = 1;
                }
            }

            foreach (var pair in charsCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
