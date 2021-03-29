using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "swap":
                        int firstIndex = int.Parse(commands[1]);
                        int secondIndex = int.Parse(commands[2]);

                        int temp = numbers[firstIndex];
                        numbers[firstIndex] = numbers[secondIndex];
                        numbers[secondIndex] = temp;
                        break;

                    case "multiply":
                        firstIndex = int.Parse(commands[1]);
                        secondIndex = int.Parse(commands[2]);

                        numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
                        break;

                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
