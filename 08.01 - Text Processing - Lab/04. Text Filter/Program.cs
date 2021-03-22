using System;
using System.Linq;

namespace _04.TextFilter
{
    class Program
    {
        static void Main()
        {
            string[] bannedWord = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWord.Length; i++)
            {
                text = text.Replace(bannedWord[i], new string('*', bannedWord[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
