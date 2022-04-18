using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];

            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input != password)
                {
                    counter++;
                    if (counter >= 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
