using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students
{
    class Program
    {
        static void Main()
        {
            List<Student> studentsData = new List<Student>();
            string[] inputData = Console.ReadLine().Split(); 

            while (inputData[0] != "end")
            {
                Student student = new Student();

                student.FirstName = inputData[0];
                student.LastName = inputData[1];
                student.Age = int.Parse(inputData[2]);
                student.Hometown = inputData[3];

                studentsData.Add(student);

                inputData = Console.ReadLine().Split();
            }

            string cityName = Console.ReadLine();

            //foreach (Student student in studentsData)
            //{
            //    if (student.Hometown == cityName)
            //    {
            //        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //    }
            //}

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
