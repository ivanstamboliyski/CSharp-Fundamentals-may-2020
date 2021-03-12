using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._2.CSharpFundamentals_Lists_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassengersPerWagon = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    train.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);

                    for (int j = 0; j < train.Count; j++)
                    {
                        if (passengers + train[j] > maxPassengersPerWagon)
                        {
                            continue;
                        }
                        else
                        {
                            train[j] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
