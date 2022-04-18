using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in names)
            {
                bool isValid = true;
                if (name.Length >= 3 && name.Length <= 16)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!(char.IsLetterOrDigit(name[i]) || name[i] == '-' || name[i] == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                else
                {
                    isValid = false;
                }

                if (isValid)
                {
                    Console.WriteLine(name);
                }
            }
    }
}
