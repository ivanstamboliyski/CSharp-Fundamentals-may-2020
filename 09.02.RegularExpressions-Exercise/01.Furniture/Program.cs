using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise._01.Furniture
{
    class Program
    {
        static void Main()
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<quantity>\d+)\b";

            string furniture;

            StringBuilder result = new StringBuilder();

            while ((furniture = Console.ReadLine()) != "Purchase")
            {
                result.AppendLine(furniture );
            }

            MatchCollection matchedFurniture = Regex.Matches(result.ToString(), pattern);

            result.Clear();

            double totalSum = 0;

            result.AppendLine("Bought furniture:");

            foreach (Match item in matchedFurniture)
            {
                result.AppendLine(item.Groups["name"].Value);
                totalSum += double.Parse(item.Groups["price"].Value) * double.Parse(item.Groups["quantity"].Value);
            }

            result.AppendLine($"Total money spend: {totalSum:f2}");

            Console.WriteLine(result);
        }
    }
}
