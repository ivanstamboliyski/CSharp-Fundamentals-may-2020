using System;
using System.Linq;

namespace _02._01.PasswordRese__04._04._2020_Group_2
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            string commands;

            while ((commands = Console.ReadLine()) != "Done")
            {
                string command = commands.Split()[0];

                switch (command)
                {
                    case "TakeOdd":
                        password = string.Concat(password.Where((c, i) => i % 2 != 0));
                        Console.WriteLine(password);
                        break;

                    case "Cut":
                        int index = int.Parse(commands.Split()[1]);
                        int lenght = int.Parse(commands.Split()[2]);
                        password = password.Remove(index, lenght);
                        Console.WriteLine(password);
                        break;

                    case "Substitute":
                        string sustring = commands.Split()[1];
                        string substitute = commands.Split()[2];

                        if (password.Contains(sustring))
                        {
                            password = password.Replace(sustring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
