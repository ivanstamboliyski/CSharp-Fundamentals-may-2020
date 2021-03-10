using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculateFirstNumFactorial(firstNum) / CalculateSecondNumFactorial(secondNum):F2}");
        }
        static double CalculateFirstNumFactorial(int firstNum) 
        {
            double factorial = 1;

            for (int i = 1; i <= firstNum; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        static double CalculateSecondNumFactorial(int secondNum)
        {
            double factorial = 1;

            for (int i = 1; i <= secondNum; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
