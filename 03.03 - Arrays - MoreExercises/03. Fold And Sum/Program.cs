using System;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] upperRow = new int[2 * k];
            int[] lowerRow = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                upperRow[i] = numbers[k - 1 - i];
            }

            for (int i = 0; i < k; i++)
            {
                upperRow[k + i] = numbers[numbers.Length - 1 - i];

            }

            for (int i = 0; i < 2 * k; i++)
            {
                lowerRow[i] = numbers[k + i];
            }

            int[] result = new int[2 * k];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
