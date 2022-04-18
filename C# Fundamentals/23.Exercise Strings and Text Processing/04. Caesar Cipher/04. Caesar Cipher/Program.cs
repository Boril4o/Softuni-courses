using System;
using System.Linq;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().Select(l => (char)(l + 3)).ToArray();
            Console.WriteLine(string.Join("", text)); Console.WriteLine("Hello World!");
        }
    }
}
