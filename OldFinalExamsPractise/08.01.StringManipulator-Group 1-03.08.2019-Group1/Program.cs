using System;
using System.Linq;

namespace _09._01.StringManipulator_Group_1_03._08._2019_Group1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string mainCommand = commands.Split()[0];

                switch (mainCommand)
                {
                    case "Translate":
                        inputString = inputString.Replace(commands.Split()[1], commands.Split()[2]);
                        Console.WriteLine(inputString);
                        break;

                    case "Includes":
                        Console.WriteLine(inputString.Contains(commands.Split()[1]));
                        break;

                    case "Start":
                        Console.WriteLine(inputString.StartsWith(commands.Split()[1]));
                        break;

                    case "Lowercase":
                        inputString = inputString.ToLower();
                        Console.WriteLine(inputString);
                        break;

                    case "FindIndex":
                        Console.WriteLine(inputString.LastIndexOf(commands.Split()[1]));
                        break;

                    case "Remove":
                        inputString = inputString.Remove(int.Parse(commands.Split()[1]), int.Parse(commands.Split()[2]));
                        Console.WriteLine(inputString);
                        break;
                }
            }
        }
    }
}
