using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Lists
{
    class Program
    {
        public static object StopWatch { get; private set; }

        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            //int minSize = Math.Min(firstList.Count, secondList.Count);

            //for (int i = 0; i < minSize; i++)
            //{
            //    result.Add(firstList[0]);
            //    firstList.RemoveAt(0);

            //    result.Add(secondList[0]);
            //    secondList.RemoveAt(0);
            //}


            //if (firstList.Count > secondList.Count)
            //{
            //    result.AddRange(firstList);
            //}
            //else
            //{
            //    result.AddRange(secondList);
            //}

            for (int i = 0; i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }

                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
