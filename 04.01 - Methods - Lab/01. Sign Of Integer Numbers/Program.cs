using System;

namespace _04._1.CSharpFundamentals_Methods_Lab
{
    class Program
    {
        static void Main()
        {
            PrintSign();
        }

        static void PrintSign()         
        {
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }     
    }
}
