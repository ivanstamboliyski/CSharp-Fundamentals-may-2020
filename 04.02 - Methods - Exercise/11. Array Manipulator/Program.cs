using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "exchange":
                        Exchange(initialArray, command);
                        break;
                    case "max":
                        FindIndexOfMaxEvenOdd(initialArray, command);
                        break;
                    case "min":
                        FindIndexOfMinEvenOdd(initialArray, command);
                        break;
                    case "first":
                        FindFirstCountElements(initialArray, command);
                        break;
                    case "last":
                        FindLastCountElements(initialArray, command);
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", initialArray) + "]");
        }
        static void Exchange(int[] initialArray, string[] command) 
        {
            int arrayIndex = int.Parse(command[1]);

            if (arrayIndex > initialArray.Length - 1 || arrayIndex < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else                   
            {
                int[] currArray = new int[arrayIndex + 1];

                for (int i = 0; i < currArray.Length; i++)
                {
                    currArray[i] = initialArray[i];
                }

                for (int i = 0; i < initialArray.Length - currArray.Length; i++)
                {
                    initialArray[i] = initialArray[i + 1 + arrayIndex];
                }

                for (int i = 0; i < currArray.Length; i++)
                {
                    initialArray[i + (initialArray.Length - currArray.Length)] = currArray[i];
                }
            }
        }
        static void FindIndexOfMaxEvenOdd(int[] initialArray, string[] command) 
        {
            int index = int.MinValue;
            int maxNum = int.MinValue;
            int currMaxNum = int.MinValue;

            if (command[1] == "even")
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] % 2 == 0)
                    {
                        currMaxNum = initialArray[i];

                        if (currMaxNum >= maxNum)
                        {
                            maxNum = currMaxNum;
                            index = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] % 2 != 0)
                    {
                        currMaxNum = initialArray[i];

                        if (currMaxNum >= maxNum)
                        {
                            maxNum = currMaxNum;
                            index = i;
                        }
                    }
                }
            }

            if (index != int.MinValue)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void FindIndexOfMinEvenOdd(int[] initialArray, string[] command)
        {
            int index = int.MaxValue;
            int minNum = int.MaxValue;
            int currMinNum = int.MaxValue;

            if (command[1] == "even")
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] % 2 == 0)
                    {
                        currMinNum = initialArray[i];

                        if (currMinNum <= minNum)
                        {
                            minNum = currMinNum;
                            index = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < initialArray.Length; i++)
                {
                    if (initialArray[i] % 2 != 0)
                    {
                        currMinNum = initialArray[i];

                        if (currMinNum <= minNum)
                        {
                            minNum = currMinNum;
                            index = i;
                        }
                    }
                }
            }

            if (index == int.MaxValue)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        static void FindFirstCountElements(int[] initialArray, string[] command)
        {
            List<int> elements = new List<int>();
            int counter = int.Parse(command[1]);

            if (counter > initialArray.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command[2] == "even")
                {
                    for (int i = 0; i < initialArray.Length; i++)
                    {
                        if (initialArray[i] % 2 == 0)
                        {
                            elements.Add(initialArray[i]);
                            counter--;
                            if (counter < 1)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < initialArray.Length; i++)
                    {
                        if (initialArray[i] % 2 != 0)
                        {
                            elements.Add(initialArray[i]);
                            counter--;
                            if (counter < 1)
                            {
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine("[" + string.Join(", ", elements) + "]");
            }
        }
        static void FindLastCountElements(int[] initialArray, string[] command)
        {
            List<int> elements = new List<int>();
            int counter = int.Parse(command[1]);

            if (counter > initialArray.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (command[2] == "even")
                {
                    for (int i = initialArray.Length - 1; i >= 0; i--)
                    {
                        if (initialArray[i] % 2 == 0 && initialArray[i] != 0)
                        {
                            elements.Add(initialArray[i]);
                            counter--;
                            if (counter < 1)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = initialArray.Length - 1; i >= 0; i--)
                    {
                        if (initialArray[i] % 2 != 0)
                        {
                            elements.Add(initialArray[i]);
                            counter--;
                            if (counter < 1)
                            {
                                break;
                            } 
                        }
                    }
                }

                elements.Reverse();
                Console.WriteLine("[" + string.Join(", ", elements) + "]");
            }
        }
    }
}
