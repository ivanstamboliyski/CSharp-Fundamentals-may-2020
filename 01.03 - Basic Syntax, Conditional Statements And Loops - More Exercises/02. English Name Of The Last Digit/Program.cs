using System;

namespace _02.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(LastDigitInEnglish(num));
        }
        static string LastDigitInEnglish(int num) 
        {
            int lastDigit = num % 10;
            string lastDigitInEnglish = "";

            if (lastDigit == 0)
            {
                lastDigitInEnglish = "zero";
            }
            else if (lastDigit == 1)
            {
                lastDigitInEnglish = "one";
            }
            else if (lastDigit == 2)
            {
                lastDigitInEnglish = "two";
            }
            else if (lastDigit == 3)
            {
                lastDigitInEnglish = "three";
            }
            else if (lastDigit == 4)
            {
                lastDigitInEnglish = "four";
            }
            else if (lastDigit == 5)
            {
                lastDigitInEnglish = "five";
            }
            else if (lastDigit == 6)
            {
                lastDigitInEnglish = "six";
            }
            else if (lastDigit == 7)
            {
                lastDigitInEnglish = "seven";
            }
            else if (lastDigit == 8)
            {
                lastDigitInEnglish = "eight";
            }
            else if (lastDigit == 9)
            {
                lastDigitInEnglish = "nine";
            }

            return lastDigitInEnglish;
        }
    }
}
