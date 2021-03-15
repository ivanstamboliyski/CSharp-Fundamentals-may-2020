using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();

            List<char> textList = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                textList.Add(text[i]);
            }

            List<char> result = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int currNum = numbers[i];

                while (currNum > 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }

                if (sum < text.Length)
                {
                    result.Add(textList[sum]);
                    textList.RemoveAt(sum);
                }
                else
                {
                    sum %= textList.Count;
                    result.Add(textList[sum]);
                    textList.RemoveAt(sum);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
