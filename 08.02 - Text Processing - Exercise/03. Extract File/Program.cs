using System;
using System.Linq;
using System.Text;

namespace _02._03.ExtractFile_Exercise
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("\\");

            string[] result = input[input.Length - 1].Split(".");

            Console.WriteLine($"File name: {result[0]}");
            Console.WriteLine($"File extension: {result[1]}");
        }
    }
}
