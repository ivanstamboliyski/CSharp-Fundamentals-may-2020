using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise._03.SoftUniBarIncome
{
    class Program
    {
        static void Main()
        {
            string input;

            double totalIncome = 0;

            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.*[0-9]*)\$";

            while ((input = Console.ReadLine()) != "end of shift")
            {
                MatchCollection validInputs = Regex.Matches(input, pattern);

                foreach (Match item in validInputs)
                {
                    double totalPrice = double.Parse(item.Groups["price"].Value) * int.Parse(item.Groups["count"].Value);

                    Console.WriteLine($"{item.Groups["name"].Value}: {item.Groups["product"].Value} - {totalPrice:f2}");

                    totalIncome += totalPrice;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
