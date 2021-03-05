using System;

namespace _02._1.DataTypesAndVariables_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = meters * 1.0m / 1000.0m;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
