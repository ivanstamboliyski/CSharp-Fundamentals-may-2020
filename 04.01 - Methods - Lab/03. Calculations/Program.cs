using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if (operation == "add")
            {
                AddNums(firstNum, secondNum);
            }
            else if (operation == "multiply")
            {
                MultiplyNums(firstNum, secondNum);
            }
            else if (operation == "subtract")
            {
                SubtractNums(firstNum, secondNum);
            }
            else if (operation == "divide")
            {
                DivideNums(firstNum, secondNum);
            }
        }

        static void AddNums(double firstNum, double secondNum) 
        {
            double result = firstNum + secondNum;
            Console.WriteLine(result);
        }
        static void MultiplyNums(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            Console.WriteLine(result);
        }
        static void SubtractNums(double firstNum, double secondNum)
        {
            double result = firstNum - secondNum;
            Console.WriteLine(result);
        }
        static void DivideNums(double firstNum, double secondNum)
        {
            double result = firstNum / secondNum;
            Console.WriteLine(result);
        }
    }
}
