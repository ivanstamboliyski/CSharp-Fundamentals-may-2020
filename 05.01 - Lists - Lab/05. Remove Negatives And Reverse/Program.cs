using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if (nums[i] < 0)
            //    {
            //        nums.RemoveAt(i);
            //        i--;
            //    }
            //}

            nums.RemoveAll(n => n < 0);

            nums.Reverse();

            if (nums.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
