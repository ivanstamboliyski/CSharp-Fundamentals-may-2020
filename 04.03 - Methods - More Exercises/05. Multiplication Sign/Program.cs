using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(MutiplicationSign(num1, num2, num3));
        }
        static string MutiplicationSign(int num1, int num2, int num3) 
        {
            string result = "";

            if ((num1 < 0 && num2 < 0 && num3 > 0) 
                ||(num2 < 0 && num3 < 0 && num1 > 0) 
                || (num3 < 0 && num1 < 0 && num2 > 0))
            {
                result = "positive";
            }
            else if (num1 < 0 || num2 < 0 || num3 < 0)
            {
                result = "negative";
            }
            else if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                result = "zero";
            }
            else
            {
                result = "positive";
            }

            return result;
        }
    }
}
