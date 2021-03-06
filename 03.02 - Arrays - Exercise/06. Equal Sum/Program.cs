using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int element = 0; element < numbers.Length; element++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int leftDigit = 0; leftDigit < element; leftDigit++)
                {
                    leftSum += numbers[leftDigit];
                }

                for (int rightDigit = element + 1; rightDigit < numbers.Length; rightDigit++)
                {
                    rightSum += numbers[rightDigit];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(element);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
