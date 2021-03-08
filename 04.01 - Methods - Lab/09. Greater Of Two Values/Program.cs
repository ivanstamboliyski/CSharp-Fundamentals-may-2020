using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int numOne = int.Parse(Console.ReadLine());
                    int numTwo = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetBigger(numOne, numTwo));
                    break;

                case "char":
                    char symbolOne = char.Parse(Console.ReadLine());
                    char symbolTwo = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetBigger(symbolOne, symbolTwo));
                    break;

                case "string":
                    string textOne = Console.ReadLine();
                    string textTwo = Console.ReadLine();
                    Console.WriteLine(GetBigger(textOne, textTwo));
                    break;
            }
        }
        static int GetBigger(int numOne, int numTwo)
        {
            return Math.Max(numOne, numTwo);
        }
        static char GetBigger(char symbolOne, char symbolTwo)
        {
            if (symbolOne > symbolTwo)
            {
                return symbolOne;
            }
            else
            {
                return symbolTwo;
            }
        }
        static string GetBigger(string textOne, string textTwo)
        {
            int comparisson = textOne.CompareTo(textTwo);

            if (comparisson > 0)
            {
                return textOne;
            }
            else
            {
                return textTwo;
            }
        }
    }
}
