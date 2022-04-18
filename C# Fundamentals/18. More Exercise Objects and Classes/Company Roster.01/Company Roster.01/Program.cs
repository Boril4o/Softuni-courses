using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster._01
{
    class Department
    {
        public string Name { get; set; }

        public double AvaregaSalary { get; set; }
    }
    class  Employee
    {
        private string _name;
        private double _salary;
        private string _department;

        public Employee(string name, double salary, string department)
        {
            this._name = name;
            this._salary = salary;
            this._department = department;
        }

        public string Name { get => _name; set => _name = value; }

        public double Salary { get => _salary; set => _salary = value; }

        public string Department { get => _department; set => _department = value; }

        public override string ToString() => $"{Name} {Salary:f2}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string department = employeeInfo[2];

                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);
            }

            List<Department> departments = new List<Department>();

            foreach (var employee in employees)
            {
                if (departments.Any(department => department.Name == employee.Department)) continue;

                double sum = avgSalary(employees, employee);

                Department department = new Department()
                {
                    Name = employee.Department,
                    AvaregaSalary = sum
                };
                
                departments.Add(department);
            }

            employees = employees.OrderByDescending(employee1 => employee1.Salary).ToList();
            string higherDepartmentSalary = HigherDepartmentAvgSalary(departments);
            Console.WriteLine($"Highest Average Salary: {higherDepartmentSalary}");
            foreach (var employee in employees)
            {
                if (employee.Department == higherDepartmentSalary)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        static string HigherDepartmentAvgSalary(List<Department> departments)
        {
            string higherDepartmentAvgSalary = "";
            double maxAvgSalary = double.MinValue;
            foreach (var department in departments)
            {
                if (department.AvaregaSalary > maxAvgSalary)
                {
                    higherDepartmentAvgSalary = department.Name;
                    maxAvgSalary = department.AvaregaSalary;
                }
            }

            return higherDepartmentAvgSalary;
        }

        static double avgSalary(List<Employee> employees, Employee employee)
        {
            string name = employee.Department;
            double salarySum = 0;
            int departmentCount = 0;
            foreach (var veribleEmployee in employees)
            {
                if (veribleEmployee.Department == employee.Department)
                {
                    salarySum += veribleEmployee.Salary;
                    departmentCount++;
                }
            }

            return salarySum / departmentCount;
        }
    }
}