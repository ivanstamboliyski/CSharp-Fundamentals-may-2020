using System;

namespace _05.SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int num = 1; num <= endNumber; num++)
            {
                int sum = 0;
                int currNUm = num;

                while (currNUm > 0)
                {
                    int digit = currNUm % 10;
                    sum += digit;
                    currNUm /= 10;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
