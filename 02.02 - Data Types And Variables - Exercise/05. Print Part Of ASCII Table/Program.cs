using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int symbol = startIndex; symbol <= endIndex; symbol++)
            {
                Console.Write((char)symbol + " ");
            }
        }
    }
}
