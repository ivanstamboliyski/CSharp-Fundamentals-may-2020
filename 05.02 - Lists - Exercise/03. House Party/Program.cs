using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLinesCount = int.Parse(Console.ReadLine());
            List<string> partyList = new List<string>();


            for (int i = 0; i < inputLinesCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];

                if (input[2] == "going!")
                {
                    if (!partyList.Contains(name))
                    {
                        partyList.Add(name);
                    }
                    else if (partyList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (input[2] == "not")
                {
                    if (!partyList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else if (partyList.Contains(name))
                    {
                        partyList.Remove(name);
                    }
                }
            }

            foreach (var item in partyList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
