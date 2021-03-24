using System;
using System.Linq;
using System.Text;

namespace _03._02.AsciiSumator_MoreExercise
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > firstChar && text[i] < secondChar)
                {
                    sum += text[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
