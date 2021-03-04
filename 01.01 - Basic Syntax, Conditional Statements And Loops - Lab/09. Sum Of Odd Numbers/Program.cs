using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int oddNum = 1; oddNum < n * 2; oddNum+=2)
            {
                sum += oddNum;
                Console.WriteLine(oddNum);
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
