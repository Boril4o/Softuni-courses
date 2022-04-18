using System;
using System.Linq;
namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            bool isEqualSums = false;
            int equalIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               
                int rightSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                
                int leftSum = 0;
                for (int k = i - 1; k >= 0; k--)
                {

                    leftSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    isEqualSums = true;
                    equalIndex = i;
                    break;
                }
                else
                {
                    rightSum = 0;
                    leftSum = 0;
                }
                
            }

            if (isEqualSums)
            {
                Console.WriteLine(equalIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
