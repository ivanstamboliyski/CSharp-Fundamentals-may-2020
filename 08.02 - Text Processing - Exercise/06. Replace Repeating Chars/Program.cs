using System;
using System.Text;

namespace _02._06.ReplaceRepeatingChars_Exercise
{
    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    result.Append(input[i]);
                }
                else if (input[i] != result[result.Length - 1])
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
