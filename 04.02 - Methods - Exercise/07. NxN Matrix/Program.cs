using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintMatrix(num);
        }
        static void PrintMatrix(int num) 
        {
            for (int i = 0; i < Math.Abs(num); i++)
            {
                for (int j = 0; j < Math.Abs(num); j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
