using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._1.CSharpFundamentals_AssociativeArrays_Lab
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    dict.Add(numbers[i], 0);
                }

                dict[numbers[i]]++;
            }

            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
