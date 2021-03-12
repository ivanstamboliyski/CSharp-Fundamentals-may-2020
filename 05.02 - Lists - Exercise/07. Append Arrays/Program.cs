using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<int> result = new List<int>(); 

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] currArray = input[i].Split();

                for (int j = 0; j < currArray.Length; j++)
                {
                    if (currArray[j] != "")
                    {
                        result.Add(int.Parse(currArray[j]));
                    }
                }

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
