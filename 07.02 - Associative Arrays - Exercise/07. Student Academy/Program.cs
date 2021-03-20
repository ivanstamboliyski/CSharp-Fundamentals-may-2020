using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputLines; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades[studentName].Add(studentGrade);
                }
                else
                {
                    studentsGrades.Add(studentName, new List<double>());
                    studentsGrades[studentName].Add(studentGrade);
                }
            }

            Dictionary<string, double> result = studentsGrades.Where(x => x.Value.Average() >= 4.50).ToDictionary(pair => pair.Key, pair => pair.Value.Average());

            foreach (var student in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
