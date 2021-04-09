using System;
using System.Linq;


namespace _07._01.Username_Retake_09._08._2019
{
    class Program
    {
        static void Main()
        {
            string user = Console.ReadLine();
            string commands;

            while ((commands = Console.ReadLine()) != "Sign up")
            {
                string mainCommand = commands.Split()[0];

                switch (mainCommand)
                {
                    case "Case":
                        if (commands.Split()[1] == "upper")
                        {
                            user = user.ToUpper();
                            Console.WriteLine(user);
                        }
                        else
                        {
                            user = user.ToLower();
                            Console.WriteLine(user);
                        }
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(commands.Split()[1]);
                        int endIndex = int.Parse(commands.Split()[2]);

                        if (startIndex < 0 || startIndex > user.Length - 1 ||
                            endIndex < 0 || endIndex > user.Length - 1)
                        {
                            continue;
                        }
                        else
                        {
                            var partToReverse = user.Substring(startIndex, endIndex - startIndex + 1).ToCharArray().Reverse().ToArray();
                            Console.WriteLine(string.Join("", partToReverse));
                        }
                        break;

                    case "Cut":
                        string substring = commands.Split()[1];
                        if (user.Contains(substring))
                        {
                            user = user.Remove(user.IndexOf(substring), substring.Length);
                            Console.WriteLine(user);
                        }
                        else
                        {
                            Console.WriteLine($"The word {user} doesn't contain {substring}.");
                        }
                        break;

                    case "Replace":
                        char searchedChar = char.Parse(commands.Split()[1]);
                        user = user.Replace(searchedChar, '*');
                        Console.WriteLine(user);
                        break;

                    case "Check":
                        searchedChar = char.Parse(commands.Split()[1]);
                        if (user.Contains(searchedChar))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {searchedChar}.");
                        }
                        break;
                }
            }
        }
    }
}
