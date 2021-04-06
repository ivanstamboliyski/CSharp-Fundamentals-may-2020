using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._02.Registration_07._12._2019_Group2
{
    class Program
    {
        static void Main()
        {
            int inputsCount = int.Parse(Console.ReadLine());
            int successfulRegistrations = 0;

            for (int input = 0; input < inputsCount; input++)
            {
                string registration = Console.ReadLine();

                string pattern = @"U\$(?<user>[A-Z][a-z]{2,})U\$P@\$(?<password>[a-z]{5,}\d+)P@\$";

                Match match = Regex.Match(registration, pattern);

                if (match.Success)
                {
                    successfulRegistrations++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["user"].Value}, Password: {match.Groups["password"].Value}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrations}");
        }
    }
}
