using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isPalidrome = false;

            while (input != "END")
            {
                int num = int.Parse(input);

                Console.WriteLine(CheckPalidromeInteger(isPalidrome, num, input).ToString().ToLower());

                input = Console.ReadLine();
            }
        }
        static bool CheckPalidromeInteger(bool isPalidrome, int num, string input) 
        {
            int[] array = new int[input.Length];

            if (array.Length == 1)
            {
                isPalidrome = true;
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    array[i] = num % 10;
                    num /= 10;
                }

                for (int i = 0; i < array.Length / 2; i++)
                {
                    if (array[i] == array[array.Length - 1 - i])
                    {
                        isPalidrome = true;
                    }
                    else
                    {
                        isPalidrome = false;
                        break;
                    }
                }
            }
 
            return isPalidrome;
        }
    }
}
