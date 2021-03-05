﻿using System;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesNumber; i++)
            {
                string input = Console.ReadLine();
                string leftNumber = "";
                string rightNumber = "";
                int count = 0;

                for (int j = 0; j < input.Length - 1; j++)
                {
                    char symbol = input[j];
                    if (symbol != ' ')
                    {
                        leftNumber += symbol;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int k = count + 1; k < input.Length; k++)
                {
                    char symbol = input[k];
                    rightNumber += symbol;
                }

                long left = long.Parse(leftNumber);
                long right = long.Parse(rightNumber);

                long maxNumber = Math.Max(left, right);
                long sum = 0;

                while (Math.Abs(maxNumber) > 0)
                {
                    sum += maxNumber % 10;
                    maxNumber /= 10;
                }

                Console.WriteLine(Math.Abs(sum));


                //int inputNumber = int.Parse(Console.ReadLine());

                //for (int i = 1; i <= inputNumber; i++)
                //{
                //    string input = Console.ReadLine();
                //    string stringBeforeSpace = input.Substring(0, input.IndexOf(" "));
                //    string stringAfterSpace = input.Substring(input.IndexOf(" ") + 1);
                //    long numLeft = (long.Parse(stringBeforeSpace));
                //    long numRight = (long.Parse(stringAfterSpace));

                //    long maxNumber = Math.Max(numLeft, numRight);
                //    long sum = 0;
                //    while (Math.Abs(maxNumber) > 0)
                //    {
                //        sum += maxNumber % 10;
                //        maxNumber /= 10;
                //    }
                //    Console.WriteLine(Math.Abs(sum));
                //}
            }
        }
    }
}
