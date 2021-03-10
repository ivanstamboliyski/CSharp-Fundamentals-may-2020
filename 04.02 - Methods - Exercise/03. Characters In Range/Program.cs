using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                PrintCharactersInRange(firstChar, secondChar);
            }
            static void PrintCharactersInRange(char firstChar, char secondChar)
            {
                for (int i = Math.Min(firstChar, secondChar) + 1; i < Math.Max(firstChar, secondChar); i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
