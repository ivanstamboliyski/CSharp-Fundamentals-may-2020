using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> wordsDict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (wordsDict.ContainsKey(words[i]))
                {
                    wordsDict[words[i]]++;
                }
                else
                {
                    wordsDict[words[i]] = 1;
                }
            }

            //foreach (var word in wordsDict)
            //{
            //    if (word.Value % 2 != 0)
            //    {
            //        Console.Write(word.Key  + " ");
            //    }
            //}

            var result = wordsDict.Where(w => w.Value % 2 != 0).ToDictionary(w => w.Key, w => w.Value);

            Console.WriteLine(string.Join(" ", result.Keys));
        }
    }
}
