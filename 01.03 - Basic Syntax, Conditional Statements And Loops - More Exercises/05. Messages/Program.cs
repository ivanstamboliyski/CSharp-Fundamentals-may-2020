using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbolsCount = int.Parse(Console.ReadLine());

            string result = "";

            for (int symbol = 1; symbol <= symbolsCount; symbol++)
            {
                int currNum = int.Parse(Console.ReadLine());
                
                int digitsCount = 0;
                int mainDigit = 0;

                while(currNum > 0)
                {
                    mainDigit = currNum % 10;
                    currNum = currNum / 10;
                    digitsCount++;
                }

                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + digitsCount - 1);
                int digit = letterIndex + 97;

                if (mainDigit == 0)
                {
                    digit = 32;
                }

                char letter = (char)digit;

                
                result += letter;
            }

            Console.WriteLine(result);
        }
    }
}
