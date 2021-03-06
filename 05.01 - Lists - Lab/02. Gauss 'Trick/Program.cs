﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count / 2 + 1; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
