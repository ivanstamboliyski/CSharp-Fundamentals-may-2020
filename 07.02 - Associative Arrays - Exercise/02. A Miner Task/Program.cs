using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main()
        {

		// METHOD 1

            string input;
            string resources = "";
            double quantity = 0;
            int counter = 0;

            var dict = new Dictionary<string, double>();

            while ((input = Console.ReadLine()) != "stop")
            {
                counter++;

                if (counter % 2 != 0)
                {
                    resources = input;
                    quantity = 0;
                }
                else
                {
                    quantity = double.Parse(input);
                }
                
                if (!dict.ContainsKey(resources))
                {
                    dict[resources] = 0;
                }

                dict[resources] += quantity;
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

		// METHOD 2

            string command;

            Dictionary<string, double> resources = new Dictionary<string, double>();
            string currResource = "";

            while ((currResource = Console.ReadLine()) != "stop")
            {
                double quantity = double.Parse(Console.ReadLine());

                if (resources.ContainsKey(currResource))
                {
                    resources[currResource] += quantity;
                    continue;
                }

                resources.Add(currResource, quantity);
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}


