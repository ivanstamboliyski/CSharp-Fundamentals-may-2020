using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int finalResult = 0;
            finalResult = Substract(finalResult, firstNum, secondNum, thirdNum);

            Console.WriteLine(finalResult);
        }
        static int Sum(int firstNum, int secondNum) 
        {
            int sumResult = firstNum + secondNum;

            return sumResult;
        }
        static int Substract(int finalResult, int firstNum, int secondNum, int thirdNum) 
        {
            finalResult = Sum(firstNum, secondNum) - thirdNum;

            return finalResult; 
        }
    }
}
