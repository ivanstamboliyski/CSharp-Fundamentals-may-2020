using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    class Program
    {
        static void Main()
        {
            List<Student> studentsData = new List<Student>();
            string[] inputData = Console.ReadLine().Split();

            while (inputData[0] != "end")
            {
                string firstName = inputData[0];
                string lastName = inputData[1];
                int age = int.Parse(inputData[2]);
                string hometown = inputData[3];
                //bool exist = false;

                //foreach (Student currStudent in studentsData)
                //{
                //    if (firstName == currStudent.FirstName && lastName == currStudent.LastName)
                //    {
                //        currStudent.Age = age;
                //        currStudent.Hometown = hometown;
                //        exist = true;
                //    }
                //}

                Student students = studentsData.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (students == null)
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;

                    studentsData.Add(student);
                }
                else
                {
                    students.Age = age;
                    students.Hometown = hometown;
                }

                inputData = Console.ReadLine().Split();
            }

            string cityName = Console.ReadLine();

            List<Student> filteredStudents = studentsData.Where(s => s.Hometown == cityName).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
