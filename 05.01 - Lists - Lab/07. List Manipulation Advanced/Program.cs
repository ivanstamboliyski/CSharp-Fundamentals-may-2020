using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] input = Console.ReadLine().Split();
            bool change = false;

            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(input[1]));
                        change = true;
                        break;

                    case "Remove":
                        numbers.Remove(int.Parse(input[1]));
                        change = true;
                        break;

                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(input[1]));
                        change = true;
                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        change = true;
                        break;

                    case "Contains":
                        if (numbers.Contains(int.Parse(input[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        List<int> evenNumbers = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenNumbers));
                        break;

                    case "PrintOdd":
                        List<int> oddNumbers = new List<int>();

                        foreach (var item in numbers)
                        {
                            if (item % 2 != 0)
                            {
                                oddNumbers.Add(item);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        break;

                    case "GetSum":
                         int sum = 0;

                        foreach (var item in numbers)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        List<int> filtered = new List<int>();
                        switch (input[1])
                        {
                            case "<":
                                foreach (var item in numbers)
                                {
                                    if (item < int.Parse(input[2]))
                                    {
                                        filtered.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", filtered));
                                break;

                            case ">":
                                foreach (var item in numbers)
                                {
                                    if (item > int.Parse(input[2]))
                                    {
                                        filtered.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", filtered));
                                break;

                            case "<=":
                                foreach (var item in numbers)
                                {
                                    if (item <= int.Parse(input[2]))
                                    {
                                        filtered.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", filtered));
                                break;

                            case ">=":
                                foreach (var item in numbers)
                                {
                                    if (item >= int.Parse(input[2]))
                                    {
                                        filtered.Add(item);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", filtered));
                                break;
                        }
                        break;
                }

                input = Console.ReadLine().Split();
            }

            if (change)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
