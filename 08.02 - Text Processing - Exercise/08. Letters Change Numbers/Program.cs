using System;

namespace _02._08.LettersChangeNumbers_Exercise
{
    class Program
    {
        static void Main()
        {
            string[] inputStrings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            double sum = 0;

            foreach (var currString in inputStrings)
            {
                double num = double.Parse(currString.Substring(1, currString.Length - 2));

                if (uppercase.Contains(currString[0]))
                {
                    num /= uppercase.IndexOf(currString[0]) + 1;
                }
                else
                {
                    num *= lowercase.IndexOf(currString[0]) + 1;
                }

                if (uppercase.Contains(currString[currString.Length - 1]))
                {
                    num -= uppercase.IndexOf(currString[currString.Length - 1]) + 1;
                }
                else
                {
                    num += lowercase.IndexOf(currString[currString.Length - 1]) + 1;
                }

                sum += num;
            }

            Console.WriteLine($"{sum:f2}");


            //var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //double sum = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    string text = input[i];

            //    double number = double.Parse(text.Substring(1, text.Length - 2));

            //    text = text.Remove(1, text.Length - 2);

            //    char letterBefore = text[0];
            //    char letterAfter = text[1];

            //    int letterBeforePosition = (int)char.Parse(letterBefore.ToString().ToUpper()) - 64;
            //    int letterAfterPosition = (int)char.Parse(letterAfter.ToString().ToUpper()) - 64;

            //    if (letterBefore.ToString().ToLower() == letterBefore.ToString())
            //    {
            //        number *= letterBeforePosition;
            //    }
            //    else
            //    {
            //        number /= letterBeforePosition;
            //    }


            //    if (letterAfter.ToString().ToLower() == letterAfter.ToString())
            //    {
            //        number += letterAfterPosition;
            //    }
            //    else
            //    {
            //        number -= letterAfterPosition;
            //    }
            //    sum += number;
            //}

            //Console.WriteLine($"{sum:f2}");
        }
    }
}
