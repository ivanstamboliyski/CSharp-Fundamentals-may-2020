using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;

                    case "Insert":
                        if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < numbers.Count)
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < numbers.Count)
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        switch (command[1])
                        {
                            case "left":
                                for (int i = 0; i < int.Parse(command[2]); i++)
                                {
                                    numbers.Add(numbers[0]);
                                    numbers.RemoveAt(0);
                                }
                                break;

                            case "right":
                                for (int i = 0; i < int.Parse(command[2]); i++)
                                {
                                    numbers.Insert(0, numbers[numbers.Count - 1]);
                                    numbers.RemoveAt(numbers.Count - 1);
                                }
                                break;
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
