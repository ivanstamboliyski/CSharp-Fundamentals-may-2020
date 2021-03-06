﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main()
        {
            int pairsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>(); 

            for (int i = 0; i < pairsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dict.ContainsKey(word))
                {
                    dict[word] = new List<string>();
                }

                dict[word].Add(synonym);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
