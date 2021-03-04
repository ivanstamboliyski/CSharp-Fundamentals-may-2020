using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int divisibleBy = 0;

            if (num % 10 == 0)
            {
                divisibleBy = 10;
            }
            else if (num % 7 == 0)
            {
                divisibleBy = 7;
            }
            else if (num % 6 == 0)
            {
                divisibleBy = 6;
            }
            else if (num % 3 == 0)
            {
                divisibleBy = 3;
            }
            else if (num % 2 == 0)
            {
                divisibleBy = 2;
            }

            if (divisibleBy != 0)
            {
                Console.WriteLine($"The number is divisible by {divisibleBy}");
            }
            else
            {
                Console.WriteLine("Not divisible");    
            }        
        }
    }
}
