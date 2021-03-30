using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FinalExam_CSharpFundamentals_09._08._2020
{
    class Program
    {
        static void Main()
        {
            string locations = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Travel")
            {
                string command = input.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];

                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(input.Split(":", StringSplitOptions.RemoveEmptyEntries)[1]);
                        string currString = input.Split(":", StringSplitOptions.RemoveEmptyEntries)[2];
                        if (index >= 0 && index < locations.Length)
                        {
                            locations = locations.Insert(index, currString);
                        }
                        Console.WriteLine(locations);
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(input.Split(":", StringSplitOptions.RemoveEmptyEntries)[1]);
                        int endIndex = int.Parse(input.Split(":", StringSplitOptions.RemoveEmptyEntries)[2]);
                        if (startIndex >= 0 && startIndex < locations.Length && endIndex >= 0 && endIndex < locations.Length)
                        {
                            locations = locations.Remove(startIndex, endIndex + 1 - startIndex);
                        }
                        Console.WriteLine(locations);
                        break;

                    case "Switch":
                        string oldString = input.Split(":", StringSplitOptions.RemoveEmptyEntries)[1];
                        string newString = input.Split(":")[2];
                        if (locations.Contains(oldString))
                        {
                            locations = locations.Replace(oldString, newString);
                        }
                        Console.WriteLine(locations);
                        break;
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {locations}");
        }
    }
}
