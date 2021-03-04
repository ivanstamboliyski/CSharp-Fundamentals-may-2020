using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string reversedText = "";

            for (int digit = 0; digit < text.Length; digit++)
            {
                reversedText = text[digit] + reversedText;
            }

            Console.WriteLine(reversedText);
        }
    }
}
