using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", nums));


            //int[] numbers = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .OrderByDescending(n => n)
            //    .ToArray();

            //int count = numbers.Length >= 3 ? 3 : numbers.Length;

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
        }
    }
}
