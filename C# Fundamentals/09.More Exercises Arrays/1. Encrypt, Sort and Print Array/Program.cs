using System;

namespace _1._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string[] names = new string[n];
            int[] namesPoints = new int[n];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                for (int j = 0; j < name.Length; j++)
                {
                    char letter = name[j];

                    bool isVowel = "aeiouAEIOU".IndexOf(letter) >= 0;

                    if (isVowel)
                    {
                        namesPoints[i] += letter * name.Length;
                    }
                    else
                    {
                        namesPoints[i] += letter / name.Length;
                    }
                }
            }

            Array.Sort(namesPoints);

            for (int i = 0; i < namesPoints.Length; i++)
            {
                Console.WriteLine(namesPoints[i]);
            }
        }
    }
}
