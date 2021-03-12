using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNum = input[0];
            int numPower = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNum)
                {
                    int startIndex = i - numPower;
                    int endIndex = i + numPower;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > numbers.Count)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        numbers.RemoveAt(startIndex);
                    }
                    i = 0;
                }
            }

            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
