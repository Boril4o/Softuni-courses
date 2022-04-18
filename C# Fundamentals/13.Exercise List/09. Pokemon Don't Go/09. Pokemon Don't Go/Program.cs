using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int removedElements = 0;
            while (sequence.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removeElement = 0;
                if (index < 0)
                {
                    removeElement = sequence[0];
                    removedElements += removeElement;
                    int lastElement = sequence.Last();
                    sequence.Insert(0, lastElement);
                    sequence.RemoveAt(1);
                    index = 0;
                    DecreaseOrincrease(sequence, index);
                    continue;
                }
                else if (index >= sequence.Count)
                {
                    removeElement = sequence[0];
                    removedElements += removeElement;
                    int lastIndex = sequence.Count - 1;
                    sequence.RemoveAt(lastIndex);
                    int firstElement = sequence.First();
                    sequence.Insert(lastIndex, firstElement);
                    index = lastIndex;
                    DecreaseOrincrease(sequence, index);
                    continue;
                }

                if (sequence.Count == 1)
                {
                    removedElements += sequence[0];
                    sequence.RemoveAt(0);
                    continue;
                }
                for (int currIndex = 0; currIndex < sequence.Count; currIndex++)
                {
                    if (index == currIndex) continue;

                    if (sequence[index] >= sequence[currIndex])
                    {
                        removeElement = sequence[index];
                        sequence[currIndex] += removeElement;
                    }
                    else
                    {
                        removeElement = sequence[index];
                        sequence[currIndex] -= removeElement;
                    }
                }
                removedElements += removeElement;
                sequence.RemoveAt(index);
            }

            Console.WriteLine(removedElements);
        }

        static void DecreaseOrincrease(List<int> sequence, int index)
        {
            int removeElement;
            for (int currIndex = 0; currIndex < sequence.Count; currIndex++)
            {
                if (sequence[index] >= sequence[currIndex])
                {
                    removeElement = sequence[index];
                    sequence[currIndex] += removeElement;
                }
                else
                {
                    removeElement = sequence[index];
                    sequence[currIndex] -= removeElement;
                }
            }
        }
    }
}