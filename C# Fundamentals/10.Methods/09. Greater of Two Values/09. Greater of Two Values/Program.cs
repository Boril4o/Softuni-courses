using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string result = getMax(type);
            
            Console.WriteLine(result);
        }

        static string getMax(string type)
        {
            string greaterValue = string.Empty;
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                if (firstNumber > secondNumber)
                {
                    greaterValue = firstNumber.ToString();
                }
                else
                {
                    greaterValue = secondNumber.ToString();
                }
            }
            else if (type == "char")
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());
                if (firstLetter > secondLetter)
                {
                    greaterValue = firstLetter.ToString();
                }
                else
                {
                    greaterValue = secondLetter.ToString();
                }
            }
            else
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();
                int comparison = firstText.CompareTo(secondText);
                if (comparison > 0)
                {
                    greaterValue = firstText;
                }
                else
                {
                    greaterValue = secondText;
                }
            }

            return greaterValue;
        }
    }
}
