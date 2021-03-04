using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            int factorialSum = 0;
            int number = num;

            while (number > 0)
            {
                int digit = number % 10;
                number = number / 10;
                int factorial = 1;

                for (int i = 2; i <= digit; i++)
                {
                    factorial = i * factorial;
                }

                factorialSum += factorial;
            }

            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
