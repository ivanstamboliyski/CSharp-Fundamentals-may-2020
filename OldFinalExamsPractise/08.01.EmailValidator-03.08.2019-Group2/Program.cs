using System;
using System.Linq;

namespace _08._01.EmailValidator_03._08._2019_Group2
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();

            string commands;

            while ((commands = Console.ReadLine()) != "Done")
            {
                string mainCommand = commands.Split()[0];

                switch (mainCommand)
                {
                    case "Change":
                        inputString = inputString.Replace(commands.Split()[1], commands.Split()[2]);
                        Console.WriteLine(inputString);
                        break;

                    case "Includes":
                        Console.WriteLine(inputString.Contains(commands.Split()[1]));
                        break;

                    case "End":
                        Console.WriteLine(inputString.EndsWith(commands.Split()[1]));
                        break;

                    case "Uppercase":
                        inputString = inputString.ToUpper();
                        Console.WriteLine(inputString);
                        break;

                    case "FindIndex":
                        Console.WriteLine(inputString.IndexOf(commands.Split()[1]));
                        break;

                    case "Cut":
                        inputString = inputString.Substring(int.Parse(commands.Split()[1]), int.Parse(commands.Split()[2]));
                        Console.WriteLine(inputString);
                        break;
                }
            }
        }
    }
}
