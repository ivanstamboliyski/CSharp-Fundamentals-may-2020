using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEven = false;

            do
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: " + Math.Abs(n));
                    isEven = true;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }

            } while (!isEven);
 


        }
    }
}
