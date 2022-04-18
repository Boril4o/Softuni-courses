using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] = new List<double>();
                }

                studentsGrades[name].Add(grade);
            }

            Dictionary<string, double> studentsAverageGrade = new Dictionary<string, double>();
            foreach (var student in studentsGrades)
            {
                string name = student.Key;
                studentsAverageGrade.Add(name, student.Value.Average());
            }

            studentsAverageGrade = studentsAverageGrade
                .OrderByDescending(s => s.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var student in studentsAverageGrade)
            {
                if (student.Value < 4.50) continue;
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
