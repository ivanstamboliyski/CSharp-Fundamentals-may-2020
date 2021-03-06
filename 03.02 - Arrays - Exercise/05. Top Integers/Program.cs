using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;

                for (int j = i; j < numbers.Length - 1; j++)
                {
                    if (numbers[i] > numbers[j + 1])
                    {
                        continue; 
                    }
                    else
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
