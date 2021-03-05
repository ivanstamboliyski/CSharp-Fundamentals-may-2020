using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLinesNumber = int.Parse(Console.ReadLine());

            int totalLitters = 0;

            for (int quantity = 1; quantity  <= inputLinesNumber; quantity ++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (totalLitters + liters <= 255)
                {
                    totalLitters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(totalLitters);
        }
    }
}
