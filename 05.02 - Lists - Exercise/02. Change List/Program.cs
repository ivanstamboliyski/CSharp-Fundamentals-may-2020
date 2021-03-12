using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                        numbers.RemoveAll(n => n == int.Parse(command[1]));
                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
