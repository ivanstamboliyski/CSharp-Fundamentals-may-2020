using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = numbers.Where(n => n > numbers.Average()).ToList();

            numbers = numbers.OrderByDescending(n => n).ToList();

            if (numbers.Count > 5)
            {
                numbers = numbers.GetRange(0, 5).ToList();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
