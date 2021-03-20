using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main()
        {
            string input;

            SortedDictionary<string, List<string>> employyesPerCompany = new SortedDictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string companyName = input.Split(" -> ")[0];
                string employeeId = input.Split(" -> ")[1];

                if (!employyesPerCompany.ContainsKey(companyName))
                {
                    employyesPerCompany.Add(companyName, new List<string>());
                    employyesPerCompany[companyName].Add(employeeId);
                }
                else if (!employyesPerCompany[companyName].Contains(employeeId))
                {
                    employyesPerCompany[companyName].Add(employeeId);
                }
            }

            foreach (var company in employyesPerCompany)
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
