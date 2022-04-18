using System;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isPalidromNumber = palidromNumberChecker(input);

                if (isPalidromNumber)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
            
            
        }

        static bool palidromNumberChecker(string input)
        {
            int number = int.Parse(input);
            if (number > 0 && number <= 9)
            {
                return true;
            }
            else
            {
                if (input[0] == input[input.Length - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
