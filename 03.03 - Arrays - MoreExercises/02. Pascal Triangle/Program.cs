using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main()
        {
            byte rowsNumber = byte.Parse(Console.ReadLine());

            for (int row = 0; row < rowsNumber; row++)
            {
                int first = 1;
                Console.Write(first);



                for (int col = 0; col < row; col++)
                {
                    int[] insideCol = new int[col];
                    insideCol[col] = col;
                }

                int last = 1;
                Console.WriteLine(last);
            }
        }
    }
}
