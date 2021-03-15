using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._3.CSharpFundamentals_Lists_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                leftRacerTime += numbers[i];

                if (numbers[i] == 0)
                {
                    leftRacerTime *= 0.8;
                }
            }

            for (int i = numbers.Length - 1; i > numbers.Length / 2; i--)
            {
                rightRacerTime += numbers[i];

                if (numbers[i] == 0)
                {
                    rightRacerTime *= 0.8;
                }
            }

            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }
        }
    }
}
