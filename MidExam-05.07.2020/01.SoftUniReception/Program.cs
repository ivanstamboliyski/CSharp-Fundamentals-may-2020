using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals_MidExam_05._07._2020
{
    class Program
    {
        static void Main()
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int allEmployeesEfficency = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            int hoursCounter = 0;

            while (studentsCount > 0)
            {
                hoursCounter++;

                if (hoursCounter % 4 == 0)
                {
                    continue;
                }

                studentsCount -= allEmployeesEfficency;
            }

            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
