using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            string result = gradesChecker(grade);
            Console.WriteLine(result);
        }

        static string gradesChecker(double grade)
        {
            string result = string.Empty;
            if (grade < 3.00)
            {
                result = "Fail";
            }
            else if (grade < 3.50)
            {
                result = "Poor";
            }
            else if (grade < 4.50)
            {
                result = "Good";
            }
            else if (grade < 5.50)
            {
                result = "Very good";
            }
            else
            {
                result = "Excellent";
            }

            return result;
        }
    }
}
