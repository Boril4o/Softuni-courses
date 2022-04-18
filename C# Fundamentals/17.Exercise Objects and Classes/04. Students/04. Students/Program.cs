using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        private string Name_;
        private string LastName_;
        private double Grade_;

        public Student(string name, string lastName, double grade)
        {
            this.Name_ = name;
            this.LastName_ = lastName;
            this.Grade_ = grade;
        }

        public string Name { get => Name_; set => Name_ = value; }

        public string LastName { get => LastName_; set => LastName_ = value; }

        public double Grade { get => Grade_; set => Grade_ = value; }

        public override string ToString() => $"{Name} {LastName}: {Grade:f2}";
    }

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);

                Student student = new Student(name, lastName, grade);
                students.Add(student);
            }

            students.OrderByDescending(student => student.Grade).ToList().ForEach(Console.WriteLine);
        }
    }
}
