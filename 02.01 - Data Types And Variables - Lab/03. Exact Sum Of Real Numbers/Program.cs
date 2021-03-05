using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int num = 1; num <= number; num++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
