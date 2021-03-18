using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._3.CSharpFundamentals_ObjectsAndClasses_MoreExercise
{
    class Program
    {
        static void Main()
        {
            int employeeNumber = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < employeeNumber; i++)
            {
                string[] inputData = Console.ReadLine().Split();

                Employee employee = new Employee(inputData[0], decimal.Parse(inputData[1]), inputData[2]);

                employees.Add(employee);
            }

            var sorted = employees.OrderBy(e => e.Department).ToList();

            decimal maxAverageSalary = decimal.MinValue;
            string maxSalariesDepartment = "";

            while (sorted.Count > 0)
            {
                decimal currAverageSalary = 0;
                decimal sum = 0;

                string currDepartment = sorted[0].Department;
                int counter = 0;

                foreach (var item in sorted)
                {
                    if (item.Department == currDepartment)
                    {
                        sum += item.Salary;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                currAverageSalary = sum / counter;

                if (currAverageSalary >= maxAverageSalary)
                {
                    maxAverageSalary = currAverageSalary;
                    maxSalariesDepartment = currDepartment;
                }

                sorted.RemoveAll(x => x.Department == currDepartment);
            }

            Console.WriteLine($"Highest Average Salary: {maxSalariesDepartment}");

            var sortedByDepartment = employees.Where(x => x.Department == maxSalariesDepartment).ToList();

            foreach (var employee in sortedByDepartment.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }

        class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }

            public Employee(string name, decimal salary, string department)
            {
                Name = name;
                Salary = salary;
                Department = department;
            }
        }
    }
}
