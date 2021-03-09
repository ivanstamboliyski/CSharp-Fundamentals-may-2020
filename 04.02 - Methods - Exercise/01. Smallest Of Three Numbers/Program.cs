using System;

namespace _04._2.CSharpFundamentals_Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int thirdNum = int.Parse(Console.ReadLine());

                Console.WriteLine(GetSmallestNum(firstNum, secondNum, thirdNum));
            }

            static int GetSmallestNum(int firstNum, int secondNum, int thirdNum)
            {
                return Math.Min(firstNum, Math.Min(secondNum, thirdNum));
            }
        }
    }
}
