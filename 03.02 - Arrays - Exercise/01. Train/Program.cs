using System;
using System.Linq;

namespace _03._2.Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainWagonsCount = int.Parse(Console.ReadLine());

            int[] peopleInTrain = new int[trainWagonsCount];
            int peopleSum = 0;

            for (int i = 0; i < trainWagonsCount; i++)
            {
                int peopleInCurrWagon = int.Parse(Console.ReadLine());
                peopleInTrain[i] = peopleInCurrWagon;
                peopleSum += peopleInTrain[i];
            }

            Console.WriteLine(string.Join(" ", peopleInTrain));
            Console.WriteLine(peopleSum);
        }
    }
}
