using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, Dictionary<string, int>> dwarfsCollection = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string dwarfName = input.Split(" <:> ")[0];
                string dwarfHatColor = input.Split(" <:> ")[1];
                int dwarfPhysics = int.Parse(input.Split(" <:> ")[2]);

                if (!dwarfsCollection.ContainsKey(dwarfHatColor))
                {
                    dwarfsCollection.Add(dwarfHatColor, new Dictionary<string, int>());
                    dwarfsCollection[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                }
                else
                {
                    if (dwarfsCollection[dwarfHatColor].ContainsKey(dwarfName) &&
                        dwarfsCollection[dwarfHatColor][dwarfName] < dwarfPhysics)
                    {
                        dwarfsCollection[dwarfHatColor][dwarfName] = dwarfPhysics;
                    }
                    else if (!dwarfsCollection[dwarfHatColor].ContainsKey(dwarfName))
                    {
                        dwarfsCollection[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    }
                }
            }

            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();

            foreach (var hatColor in dwarfsCollection.OrderByDescending(d => d.Value.Count))
            {
                foreach (var dwarf in hatColor.Value)
                {
                    sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key}", dwarf.Value);
                }
            }

            foreach (var dwarf in sortedDwarfs.OrderByDescending(d => d.Value))
            {
                Console.WriteLine($"{dwarf.Key} <-> {dwarf.Value}");
            }
        }
    }
}
