using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<char> textList = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                textList.Add(input[i]);
            }

            List<int> numbersList = new List<int>();

            for (int i = 0; i < textList.Count; i++)
            {
                if (char.IsDigit(textList[i]))
                {
                    numbersList.Add(int.Parse(textList[i].ToString()));
                    textList.RemoveAt(i);
                    i--;
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            List<char> result = new List<char>();                  

            int takeIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeNum = takeList[i];
                int skipNum = skipList[i];

                for (int j = takeIndex; j < takeIndex + takeNum && j < textList.Count; j++)
                {
                    result.Add(textList[j]);
                }

                takeIndex += takeNum + skipNum;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
