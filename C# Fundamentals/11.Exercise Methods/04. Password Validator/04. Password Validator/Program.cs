using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isPasswordLengthValid = validatePasswordLength(password);
            bool isPasswordContainsValidSymbols = validatePasswordText(password);
            bool isDigitInPasswordAttLeastTwo = validatePasswordDigit(password);
            
            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isDigitInPasswordAttLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPasswordContainsValidSymbols && isDigitInPasswordAttLeastTwo && isPasswordLengthValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        
        static bool validatePasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool validatePasswordText(string password)
        {
            foreach (char charachter in password)
            {
                
                if (!char.IsLetterOrDigit(charachter))
                {
                    return false;
                }
            }

            return true;
        }

        static bool validatePasswordDigit(string password)
        {
            int countDigit = 0;
            foreach  (char charachter in password)
            {
                if (char.IsDigit(charachter))
                {
                    countDigit++;
                }

                if (countDigit == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
