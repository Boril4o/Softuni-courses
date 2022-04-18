using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] companyInfo = input
                    .Split(" -> ");

                string companyName = companyInfo[0];
                string employeeID = companyInfo[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }

                if (!companies[companyName].Contains(employeeID)) companies[companyName].Add(employeeID);

                input = Console.ReadLine();
            }

            companies = companies
                .OrderBy(company => company.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var company in companies)
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
