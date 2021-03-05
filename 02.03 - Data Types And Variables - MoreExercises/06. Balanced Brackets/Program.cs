using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            int openingBracketCounter = 0;
            int closingBracketCounter = 0;
            bool areBalanced = true;

            for (int symbol = 0; symbol < inputLines; symbol++)
            {
                string text = Console.ReadLine();

                if (text == "(")
                {
                    if (closingBracketCounter > openingBracketCounter)
                    {
                        areBalanced = false;
                        break;
                    }
                    else
                    {
                        openingBracketCounter++;
                    }
                }
                if (text == ")")
                {
                    closingBracketCounter++;
                }
                if (Math.Abs(openingBracketCounter - closingBracketCounter) > 1)
                {
                    areBalanced = false;
                    break;
                }
            }

            if (openingBracketCounter == closingBracketCounter && areBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
