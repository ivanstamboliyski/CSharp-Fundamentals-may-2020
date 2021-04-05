using System;
using System.Linq;

namespace _05._01.Nikulden_sCharity_07._12._2019
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string commands;

            while ((commands = Console.ReadLine()) != "Finish")
            {
                string mainCommand = commands.Split()[0];

                switch (mainCommand)
                {
                    case "Replace":
                        char currentChar = char.Parse(commands.Split()[1]);
                        char newChar = char.Parse(commands.Split()[2]);
                        message = message.Replace(currentChar, newChar);
                        Console.WriteLine(message);
                        break;

                    case "Cut":
                        int startIndex = int.Parse(commands.Split()[1]);
                        int endIndex = int.Parse(commands.Split()[2]);
                        if (startIndex < 0 || startIndex > message.Length - 1 ||
                            endIndex < 0 || endIndex > message.Length - 1)
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        else
                        {
                            message = message.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(message);
                        }
                        break;

                    case "Make":
                        switch (commands.Split()[1])
                        {
                            case "Upper":
                                message = message.ToUpper();
                                Console.WriteLine(message);
                                break;

                            case "Lower":
                                message = message.ToLower();
                                Console.WriteLine(message);
                                break;
                        }
                        break;

                    case "Check":
                        string currString = commands.Split()[1];
                        if (message.Contains(currString))
                        {
                            Console.WriteLine($"Message contains {currString}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {currString}");
                        }
                        break;

                    case "Sum":
                        startIndex = int.Parse(commands.Split()[1]);
                        endIndex = int.Parse(commands.Split()[2]);
                        if (startIndex < 0 || startIndex > message.Length - 1 ||
                            endIndex < 0 || endIndex > message.Length - 1)
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        else
                        {
                            string sustring = message.Substring(startIndex, endIndex - startIndex + 1);
                            int sum = sustring.Select(x => (int)x).Sum();
                            Console.WriteLine(sum);
                        }
                        break;
                }
            }
        }
    }
}
