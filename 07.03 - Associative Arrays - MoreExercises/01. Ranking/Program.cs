using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._3.CSharpFundamentals_AssociativeArrays_MoreExercise
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string contestName = input.Split(":")[0];
                string password = input.Split(":")[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, password);
                }
                else if (contests[contestName] != password)
                {
                    contests[contestName] = password;
                }
            }

            Dictionary<string, Dictionary<string, double>> studentsRanking = new Dictionary<string, Dictionary<string, double>>();

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] inpuData = input.Split("=>");
                string contestName = inpuData[0];
                string password = inpuData[1];
                string studentName = inpuData[2];
                double points = double.Parse(inpuData[3]);

                if (contests.ContainsKey(contestName) &&
                    contests[contestName] == password &&
                    !studentsRanking.ContainsKey(studentName))
                {
                    studentsRanking.Add(studentName, new Dictionary<string, double>());
                    studentsRanking[studentName].Add(contestName, points);
                }
                else if (contests.ContainsKey(contestName) &&
                         contests[contestName] == password)
                {
                    if (studentsRanking.ContainsKey(studentName) &&
                        studentsRanking[studentName].ContainsKey(contestName) &&
                        studentsRanking[studentName][contestName] < points)
                    {
                        studentsRanking[studentName][contestName] = points;
                    }
                    else if (!studentsRanking[studentName].ContainsKey(contestName))
                    {
                        studentsRanking[studentName].Add(contestName, points);
                    }
                }
            }

            string bestCandidate = string.Empty;
            double bestCandidatePoints = double.MinValue;

            foreach (var student in studentsRanking)
            {
                double currBestCandidatePoints = student.Value.Values.Sum();

                if (currBestCandidatePoints > bestCandidatePoints)
                {
                    bestCandidate = student.Key;
                    bestCandidatePoints = currBestCandidatePoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidatePoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var student in studentsRanking.OrderBy(s => s.Key))
            {
                Console.WriteLine(student.Key);

                foreach (var item in student.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
