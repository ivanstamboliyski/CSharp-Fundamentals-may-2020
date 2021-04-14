using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\||#)(?<name>[A-Za-z ]+)\1(?<expiration>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";

            MatchCollection validFoods = Regex.Matches(input, pattern);

            int totalCalories = 0;

            foreach (Match item in validFoods)
            {
                totalCalories += int.Parse(item.Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");

            foreach (Match item in validFoods)
            {
                Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {item.Groups["expiration"].Value}, Nutrition: {item.Groups["calories"].Value}");
            }
        }
    }
}
