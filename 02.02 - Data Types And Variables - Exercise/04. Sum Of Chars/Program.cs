using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLinesNumber = int.Parse(Console.ReadLine());

            int totalSum = 0;

            for (int character = 1; character <= inputLinesNumber; character++)
            {
                char symbol = char.Parse(Console.ReadLine());
                totalSum += symbol;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
