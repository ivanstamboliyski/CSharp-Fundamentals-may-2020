using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            PrintMiddleCharachter(inputText);
        }
        static void PrintMiddleCharachter(string inputText) 
        {
            if (inputText.Length % 2 != 0)
            {
                Console.WriteLine(inputText[inputText.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{inputText[inputText.Length / 2 - 1]}{inputText[inputText.Length / 2]}");
            }
        }
    }
}
