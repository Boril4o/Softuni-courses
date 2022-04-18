using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> originalData = new List<string>(data);

            string[] command = new string[3];

            while (true)
            {
                command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "3:1")
                {
                    Console.Write(string.Join(" ", data));
                    break;
                }

                else if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    Merge(data, startIndex, endIndex);
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    Divide(data, index, partitions);
                }
            }

            static void Merge(List<string> data, int startIndex, int endIndex)
            {
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > data.Count - 1)
                {
                    endIndex = data.Count - 1;
                }

                for (int j = startIndex + 1; j <= endIndex; j++)
                {
                    data[startIndex] += data[startIndex + 1];
                    data.RemoveAt(startIndex + 1);
                }
            }

            static void Divide(List<string> data, int index, int partitions)
            {
                string partitionData = data[index];
                data.RemoveAt(index);
                int partSize = partitionData.Length / partitions;
                int reminder = partitionData.Length % partitions;

                List<string> tmpData = new List<string>();

                for (int i = 0; i < partitions; i++)
                {
                    string tmpString = null;

                    for (int p = 0; p < partSize; p++)
                    {
                        tmpString += partitionData[(i * partSize) + p];
                    }

                    if (i == partitions - 1 && reminder != 0)
                    {
                        tmpString += partitionData.Substring(partitionData.Length - reminder);
                    }

                    tmpData.Add(tmpString);
                }

                data.InsertRange(index, tmpData);
            }
        }
    }
}

