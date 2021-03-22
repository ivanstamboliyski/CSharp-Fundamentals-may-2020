using System;

namespace _08._1.CSharpFundamentals_TextProcessing_Lab
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    result += input[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
