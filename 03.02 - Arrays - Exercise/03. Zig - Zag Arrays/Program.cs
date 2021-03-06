using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysLenght = int.Parse(Console.ReadLine());

            int[] arrOne = new int[arraysLenght];
            int[] arrTwo = new int[arraysLenght];

            for (int i = 1; i <= arraysLenght; i++)
            {
                int[] arrThree = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    arrOne[i - 1] = arrThree[0];
                    arrTwo[i - 1] = arrThree[1];
                }
                else
                {
                    arrOne[i - 1] = arrThree[1];
                    arrTwo[i - 1] = arrThree[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
