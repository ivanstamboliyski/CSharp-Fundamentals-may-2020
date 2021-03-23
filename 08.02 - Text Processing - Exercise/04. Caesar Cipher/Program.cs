using System;
using System.Linq;
using System.Text;

namespace _02._04.CaesarCipher_Exercise
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string encrypted = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int currSymbol = input[i] + 3;

                encrypted += (char)currSymbol;
            }

            Console.WriteLine(encrypted);
        }
    }
}
