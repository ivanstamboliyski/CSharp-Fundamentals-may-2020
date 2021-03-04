using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int num = startNum; num <= endNum; num++)
            {
                Console.Write(num + " ");
                sum += num;
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
