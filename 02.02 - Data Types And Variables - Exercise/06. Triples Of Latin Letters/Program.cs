using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNum = int.Parse(Console.ReadLine());

            for (char symbol1 = 'a'; symbol1 < 'a' + givenNum; symbol1++)
            {
                for (char symbol2 = 'a'; symbol2 < 'a' + givenNum; symbol2++)
                {
                    for (char symbol3 = 'a'; symbol3 < 'a' + givenNum; symbol3++)
                    {
                        Console.WriteLine($"{symbol1}{symbol2}{symbol3}");
                    }
                }
            }
        }
    }
}
