using System;

namespace _04._3.CSharpFundamentals_Methods_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int intNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetResult(intNum)); 
                    break;
                case "real":
                    double realNum = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{GetResult(realNum):F2}");
                    break;
                case "string":
                    string text = Console.ReadLine();
                    Console.WriteLine(GetResult(text));
                    break;
            }
        }
        static int GetResult(int num) 
        {
            int result = num * 2;
            return result;
        }
        static double GetResult(double realNum) 
        {
            double result = realNum * 1.50;
            return result;
        }
        static string GetResult(string text)
        {
            string result = "$" + text + "$";
            return result;
        }
    }
}
