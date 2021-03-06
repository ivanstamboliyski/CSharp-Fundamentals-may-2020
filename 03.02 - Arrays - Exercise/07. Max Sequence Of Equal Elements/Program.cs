using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string maxSequence = "";

            for (int i = 0; i < arr.Length; i++)
            {
                string currSequence = arr[i].ToString() + " ";

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currSequence += arr[i].ToString() + " ";
                    }
                    else
                    {
                        break;
                    }
                }

                if (currSequence.Length > maxSequence.Length)
                {
                    maxSequence = currSequence;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
