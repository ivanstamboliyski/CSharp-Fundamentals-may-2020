using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main()
        {
            StringRandomizer randomizer = new StringRandomizer();
            randomizer.Words = Console.ReadLine().Split();
            randomizer.Randomise();
            randomizer.PrintWords();
        }
    }
    public class StringRandomizer 
    {
        public string[] Words;

        public void Randomise ()
        {
            Random randIndex = new Random();

            for (int i = 0; i < Words.Length; i++)
            {
                int randomPosition = randIndex.Next(Words.Length);
                string temp = Words[i];
                Words[i] = Words[randomPosition];
                Words[randomPosition] = temp;
            }
        }

        public void PrintWords() 
        {
            Console.WriteLine(string.Join(Environment.NewLine, Words));
        }
        
    }
}
