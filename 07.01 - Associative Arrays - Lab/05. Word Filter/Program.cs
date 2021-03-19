using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.WordFilter
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                 .Split()
                 .Where(w => w.Length % 2 == 0)
                 .ToList();

            words.ForEach(Console.WriteLine);

            
        }
    }
}
