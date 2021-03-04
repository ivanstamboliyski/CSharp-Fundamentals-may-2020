using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {counter} = {n * counter}");
                counter++;

            } while (counter <= 10);
        }
    }
}
