using System;
using System.Text.RegularExpressions;

namespace _09.CSharpFundamentals_RegularExpressions
{
    class Program
    {
        static void Main()
        {
            string regex = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchednames = Regex.Matches(names, regex);

            foreach (Match name in matchednames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
