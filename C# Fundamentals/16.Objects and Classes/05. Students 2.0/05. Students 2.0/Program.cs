using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int age { get; set; }

        public string homeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] studentInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string town = studentInfo[3];

                if (IsStudentExisting(firstName, lastName, students))
                {
                    student student = GetStudent(students, firstName, lastName);
                    student.age = age;
                    student.homeTown = town;
                }
                else
                {
                    student student = new student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        age = age,
                        homeTown = town
                    };
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            string city = Console.ReadLine();
            foreach (student student in students)
            {
                if (student.homeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.age} years old.");
                }
            }
        }

        static bool IsStudentExisting(string firstName, string lastName, List<student> students)
        {
            foreach (student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static student GetStudent(List<student> students, string firstName, string lastName)
        {
            student existedStudent = new student();
            foreach (student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existedStudent = student;
                }
            }

            return existedStudent;
        }
    }
}
