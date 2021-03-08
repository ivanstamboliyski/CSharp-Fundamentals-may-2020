using System;
using System.Linq;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            //int oddSum = 0;
            //int evenSum = 0;

            //while (Math.Abs(num) > 0)
            //{
            //    int lastDigit = Math.Abs(num % 10);

            //    if (lastDigit % 2 == 0)
            //    {
            //        evenSum += lastDigit;
            //    }
            //    else
            //    {
            //        oddSum += lastDigit;
            //    }

            //    num /= 10;
            //}

            //Console.WriteLine(oddSum * evenSum);

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }
        static int GetMultipleOfEvenAndOdds(int num) 
        {
            return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
        }
        static int GetSumOfEvenDigits(int num) 
        {
            int evenSum = 0;

            while (Math.Abs(num) > 0)
            {
                int lastDigit = Math.Abs(num % 10);

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }

                num /= 10;
            }

            return evenSum;
        }
        static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;

            while (Math.Abs(num) > 0)
            {
                int lastDigit = Math.Abs(num % 10);

                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }

                num /= 10;
            }

            return oddSum;
        }
    }
}
