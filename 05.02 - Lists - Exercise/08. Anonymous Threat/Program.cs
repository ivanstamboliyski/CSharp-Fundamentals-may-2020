using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main()
        {
            List<string> inputText = Console.ReadLine().Split().ToList();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "3:1")
            {
                switch (commands[0])
                {
                    case "merge":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);

                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        if (endIndex >= inputText.Count)
                        {
                            endIndex = inputText.Count - 1;
                        }

                        for (int i = startIndex; i < endIndex; i++)
                        {
                            inputText[startIndex] += inputText[startIndex + 1];
                            inputText.RemoveAt(startIndex + 1);
                        }
                        break;

                    case "divide":

                        int index = int.Parse(commands[1]);
                        int partitions = int.Parse(commands[2]);
                        int partitionLenght = inputText[index].Length / partitions; ;

                        List<char> currElement = new List<char>();

                        for (int i = 0; i < inputText[index].Length; i++)
                        {
                            currElement.Add(inputText[index][i]);
                        }

                        if (inputText[index].Length % partitions == 0)
                        {
                            for (int i = 0; i < partitions; i++)
                            {
                                string nextElement = "";

                                for (int j = 0; j < partitionLenght; j++)
                                {
                                    nextElement += currElement[0];
                                    currElement.RemoveAt(0);
                                }

                                inputText.Insert(index, nextElement);
                                index++;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < partitions; i++)
                            {
                                string nextElement = "";

                                if (i < partitions - 1)
                                {
                                    for (int j = 0; j < partitionLenght; j++)
                                    {
                                        nextElement += currElement[0];
                                        currElement.RemoveAt(0);
                                    }
                                }
                                else
                                {
                                    int lastPartitionLenght = currElement.Count;

                                    for (int j = 0; j < lastPartitionLenght; j++)
                                    {
                                        nextElement += currElement[0];
                                        currElement.RemoveAt(0);
                                    }
                                }

                                inputText.Insert(index, nextElement);
                                index++;
                            }
                        }

                        inputText.RemoveAt(index);
                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", inputText));
        }
    }
}
