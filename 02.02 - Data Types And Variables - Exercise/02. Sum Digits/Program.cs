using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main()
        {
            int givenNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int digit = 0;

            while (givenNum > 0)
            {
                digit = givenNum % 10;
                sum += digit;
                givenNum /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
