using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                string inputText = Console.ReadLine();

                Console.WriteLine(CountVowels(inputText));
            }

            static int CountVowels(string input)
            {
                int counter = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u' || input[i] == 'y' || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U' || input[i] == 'Y')
                    {
                        counter++;
                    }
                }

                return counter;
            }
        }
    }
}
