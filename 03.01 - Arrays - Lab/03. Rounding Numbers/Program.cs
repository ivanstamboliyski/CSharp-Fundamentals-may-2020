using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currNum = numbers[i];
                currNum = Math.Round(currNum, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Convert.ToDecimal(currNum)}");
            }


            //double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //int[] roundedNums = new int[nums.Length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            //}

            //for (int i = 0; i < roundedNums.Length; i++)
            //{
            //    Console.WriteLine($"{nums[i]} => {roundedNums[i]}");
            //}

        }
    }
}
