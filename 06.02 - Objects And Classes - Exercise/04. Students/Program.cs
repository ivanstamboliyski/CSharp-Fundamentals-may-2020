using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(); 

            for (int i = 0; i < studentsCount; i++)
            {
                string[] currStudentInfo = Console.ReadLine().Split();

                Student student = new Student(currStudentInfo[0], currStudentInfo[1], double.Parse(currStudentInfo[2]));

                students.Add(student);
            }

            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(s => s.Grade)));
        }

        class Student 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade:F2}";
            }
        }
    }
}
