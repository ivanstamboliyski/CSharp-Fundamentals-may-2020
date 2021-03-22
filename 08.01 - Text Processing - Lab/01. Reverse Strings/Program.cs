using System;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main()
        {
            //string input;

            //while ((input = Console.ReadLine()) != "end")
            //{
            //    var reversed = string.Empty;

            //    for (int i = input.Length - 1; i >= 0; i--)
            //    {
            //        reversed += input[i];
            //    }

            //    Console.WriteLine($"{input} = {reversed}");
            //}

            char[] input = Console.ReadLine().ToCharArray();
            input = input.Reverse().ToArray();

            Console.WriteLine(string.Join("", input));
        }
    }
}
