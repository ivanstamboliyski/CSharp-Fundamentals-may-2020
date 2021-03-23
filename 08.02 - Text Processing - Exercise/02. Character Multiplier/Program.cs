using System;
using System.Linq;
using System.Text;

namespace _02._02._CharacterMultiplier__Exercise
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int sum = 0;

            for (int i = 0; i < Math.Max(input[0].Length, input[1].Length); i++)
            {
                if (i < input[0].Length && i < input[1].Length)     // 123 522
                {
                    sum += input[0][i] * input[1][i];
                }
                else
                {
                    if (input[0].Length > input[1].Length)
                    {
                        sum += input[0][i];
                    }
                    else
                    {
                        sum += input[1][i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
