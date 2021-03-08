using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                PrintColumn(row);
            }

            for (int row = num - 1; row > 0; row--)
            {
                PrintColumn(row);
            }
        }
        static void PrintColumn(int row) 
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
