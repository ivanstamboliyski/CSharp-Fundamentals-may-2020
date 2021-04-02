using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._01.ActivationKeys__04._04._2020_Group_1
{
    class Program
    {
        static void Main()
        {
            string activationKey = Console.ReadLine();

            string instructions;

            while ((instructions = Console.ReadLine()) != "Generate")
            {
                string command = instructions.Split(">>>")[0];

                switch (command)
                {
                    case "Contains":
                        string substring = instructions.Split(">>>")[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        string cases = instructions.Split(">>>")[1];
                        int startIndex = int.Parse(instructions.Split(">>>")[2]);
                        int endIndex = int.Parse(instructions.Split(">>>")[3]);
                        if (cases == "Upper")
                        {
                            activationKey = activationKey.Replace(activationKey.Substring(startIndex, endIndex - startIndex), activationKey.Substring(startIndex, endIndex - startIndex).ToUpper());
                        }
                        else
                        {
                            activationKey = activationKey.Replace(activationKey.Substring(startIndex, endIndex - startIndex), activationKey.Substring(startIndex, endIndex - startIndex).ToLower());
                        }
                        Console.WriteLine(activationKey);
                        break;

                    case "Slice":
                        startIndex = int.Parse(instructions.Split(">>>")[1]);
                        endIndex = int.Parse(instructions.Split(">>>")[2]);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
