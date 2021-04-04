using System;
using System.Linq;

namespace _04._01.SecretChat_Retake_13._12._2019
{
    class Program
    {
        static void Main()
        {
            string skill = Console.ReadLine();

            string commands;

            
            while ((commands = Console.ReadLine()) != "For Azeroth")
            {
                string mainCommand = commands.Split()[0];

                switch (mainCommand)
                {
                    case "GladiatorStance":
                        skill = skill.ToUpper();
                        Console.WriteLine(skill);
                        break;

                    case "DefensiveStance":
                        skill = skill.ToLower();
                        Console.WriteLine(skill);
                        break;

                    case "Dispel":
                        int index = int.Parse(commands.Split()[1]);
                        string letter = commands.Split()[2];

                        if (index < 0 || index > skill.Length - 1)
                        {
                            Console.WriteLine("Dispel too weak.");
                            continue;
                        }

                        skill = skill.Remove(index, 1);
                        skill = skill.Insert(index, letter);
                        Console.WriteLine("Success!");
                        break;

                    case "Target":
                        string firstSubstring = commands.Split()[2];

                        switch (commands.Split()[1])
                        {
                            case "Change":
                                string secondSubstring = commands.Split()[3];
                                skill = skill.Replace(firstSubstring, secondSubstring);
                                Console.WriteLine(skill);
                                break;

                            case "Remove":

                                skill = skill.Remove(skill.IndexOf(firstSubstring), firstSubstring.Length);
                                Console.WriteLine(skill);
                                break;

                            default:
                                Console.WriteLine("Command doesn't exist!");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }
            }
        }
    }
}
