using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, double> studentsPoints = new Dictionary<string, double>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] inputData = input.Split("-");

                string username = inputData[0];
                string language = inputData[1];

                if (inputData[1] == "banned")
                {
                    studentsPoints.Remove(username);
                    continue;
                }

                double points = double.Parse(inputData[2]);

                if (!studentsPoints.ContainsKey(username))
                {
                    studentsPoints.Add(username, points);
                }
                else if (studentsPoints[username] < points)
                {
                    studentsPoints[username] = points;
                }

                if (!languageSubmissions.ContainsKey(language))
                {
                    languageSubmissions.Add(language, 1);
                }
                else
                {
                    languageSubmissions[language]++;
                }
            }

            Console.WriteLine("Results:");

            foreach (var student in studentsPoints.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in languageSubmissions.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
