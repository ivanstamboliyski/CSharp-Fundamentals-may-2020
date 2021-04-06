using System;
using System.Linq;

namespace _06._01.EmailValidator_07._12._2019
{
    class Program
    {
        static void Main()
        {
            string email = Console.ReadLine();

            string commands;

            while ((commands = Console.ReadLine()) != "Complete")
            {
                string mainCommand = commands.Split()[0];

                switch (mainCommand)
                {
                    case "Make":
                        if (commands.Split()[1] == "Upper")
                        {
                            email = email.ToUpper();
                            Console.WriteLine(email);
                        }
                        else
                        {
                            email = email.ToLower();
                            Console.WriteLine(email);
                        }
                        break;

                    case "GetDomain":
                        int count = int.Parse(commands.Split()[1]);
                        var lastN = email.ToCharArray().TakeLast(count);
                        Console.WriteLine(string.Join("", lastN));
                        break;

                    case "GetUsername":
                        if (!email.Contains('@'))
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        else
                        {
                            Console.WriteLine(email.Substring(0, email.IndexOf("@")));
                        }
                        break;

                    case "Replace":
                        char searchedChar = char.Parse(commands.Split()[1]);
                        email = email.Replace(searchedChar, '-');
                        Console.WriteLine(email);
                        break;

                    case "Encrypt":
                        int[] encrypted = email.Select(x => (int)x).ToArray();
                        Console.WriteLine(string.Join(" ", encrypted));
                        break;
                }
            }
        }
    }
}
