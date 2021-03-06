using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int sequencesLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string longhestSequence = "";
            string[] bestDna = new string[sequencesLenght];
            int bestCurrSequenceIndex = int.MaxValue;
            int bestSequenceIndex = int.MaxValue;
            int bestSequenceSum = int.MinValue;
            int counter = 0;
            int sample = 0;

            while (input != "Clone them!")
            {
                string[] dna = input.Split("!", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string currSequence = "";
                string longhestCurrSequence = "";
                int index = 0;
                int currSequenceSum = 0;
                counter++;

                for (int i = 0; i < dna.Length; i++)
                {
                    currSequenceSum += int.Parse(dna[i]);

                    if (dna[i] == "1")
                    {
                        currSequence += dna[i];

                        if (currSequence == "1")
                        {
                            index = i;
                        }
                    }
                    else
                    {
                        currSequence = "";
                        continue;
                    }

                    if (currSequence.Length > longhestCurrSequence.Length)
                    {
                        longhestCurrSequence = currSequence;
                        bestCurrSequenceIndex = index;
                    }
                }

                if (longhestCurrSequence.Length > longhestSequence.Length)
                {
                    bestSequenceIndex = bestCurrSequenceIndex;
                    longhestSequence = longhestCurrSequence;
                    bestSequenceSum = currSequenceSum;
                    sample = counter;
                    bestDna = dna;
                }
                else if (bestCurrSequenceIndex < bestSequenceIndex)
                {
                    bestSequenceIndex = bestCurrSequenceIndex;
                    longhestSequence = longhestCurrSequence;
                    bestSequenceSum = currSequenceSum;
                    sample = counter;
                    bestDna = dna;
                }
                else if (currSequenceSum > bestSequenceSum)
                {
                    bestSequenceIndex = bestCurrSequenceIndex;
                    longhestSequence = longhestCurrSequence;
                    bestSequenceSum = currSequenceSum;
                    sample = counter;
                    bestDna = dna;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {sample} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
