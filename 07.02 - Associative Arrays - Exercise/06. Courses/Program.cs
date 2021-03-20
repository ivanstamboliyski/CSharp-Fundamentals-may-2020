using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Courses
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, List<string>> enrolledStudentsPerCourse = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputData = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = inputData[0];
                string studentName = inputData[1];

                if (!enrolledStudentsPerCourse.ContainsKey(courseName))
                {
                    enrolledStudentsPerCourse.Add(courseName, new List<string>());
                    enrolledStudentsPerCourse[courseName].Add(studentName);
                }
                else
                {
                    enrolledStudentsPerCourse[courseName].Add(studentName);
                }
            }

            foreach (var course in enrolledStudentsPerCourse.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var user in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
