using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine(GetRepeatedString(input, repeatCount));
        }
        static string GetRepeatedString(string input, int repeat) 
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < repeat; i++)
            {
                result.Append(input);
            }

            return result.ToString();
        }
    }
}
