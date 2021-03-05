using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

             bool areEqual = false;

            if (Math.Abs(firstNum - secondNum) < 0.000001)
            {
                areEqual = true;
            }

            Console.WriteLine(areEqual);
        }
    }
}
