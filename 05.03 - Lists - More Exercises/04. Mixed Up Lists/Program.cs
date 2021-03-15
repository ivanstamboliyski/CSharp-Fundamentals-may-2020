using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbersTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mixedList = new List<int>();

            int end = Math.Min(numbersOne.Count, numbersTwo.Count) * 2;

            for (int i = 0; i < end; i++)
            {
                if (i % 2 == 0)                             // 1 92 5 51 23 54 64 31 2 12 3 23 34 43
                {
                    mixedList.Add(numbersOne[0]);
                    numbersOne.RemoveAt(0);
                }
                else if (i % 2 != 0)
                {
                    mixedList.Add(numbersTwo[numbersTwo.Count - 1]);
                    numbersTwo.RemoveAt(numbersTwo.Count - 1);
                }
            }

            int startConstrain = 0;
            int endConstrain = 0;

            if (numbersOne.Count > numbersTwo.Count)
            {
                startConstrain = numbersOne[0];
                endConstrain = numbersOne[1];
            }
            else
            {
                startConstrain = numbersTwo[0];
                endConstrain = numbersTwo[1];
            }

            List<int> output = new List<int>();

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > Math.Min(startConstrain, endConstrain) &&
                    mixedList[i] < Math.Max(startConstrain, endConstrain))
                {
                    output.Add(mixedList[i]);
                }
            }

            output.Sort();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
