using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            var area = width * length;

            var volume = area * height / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
