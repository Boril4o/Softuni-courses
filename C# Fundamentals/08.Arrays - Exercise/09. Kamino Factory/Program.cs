using System;
using System.Linq;
namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int bestSequenceSize = 0;
            int[] bestSequence = new int[size];
            int bestSequenceStartingIndex = 0;
            int bestSequenceSum = 0;
            int bestSample = 1;
            int sample = 0;

            while (true)
            {
                string input = Console.ReadLine();
                sample++;

                if (input == "Clone them!")
                {
                    break;
                }

                int[] sequence = input
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


                int sequenceSum = 0;
                for (int i = 0; i < sequence.Length; i++)
                {
                    sequenceSum += sequence[i];
                }

                for (int i = 0; i < sequence.Length; i++)
                {
                    int currentElement = sequence[i];

                    if (currentElement == 0)
                    {
                        continue;
                    }

                    int currentSequenceSize = 1;

                    for (int j = i + 1; j < sequence.Length; j++)
                    {
                        int rightElement = sequence[j];

                        if (currentElement == rightElement)
                        {
                            currentSequenceSize++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (bestSequenceSize < currentSequenceSize)
                    {
                        bestSequenceSize = currentSequenceSize;
                        bestSequence = sequence;
                        bestSequenceStartingIndex = i;
                        bestSequenceSum = sequenceSum;
                        bestSample = sample;
                    }
                    else if (currentSequenceSize == bestSequenceSize)
                    {
                        if (bestSequenceStartingIndex > i)
                        {
                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSample = sample;
                            bestSequence = sequence;
                        }
                        else if (bestSequenceStartingIndex == i && sequenceSum > bestSequenceSum)
                        {
                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSample = sample;
                            bestSequence = sequence;
                        }
                    }
                }

            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));

        }
    }
}
