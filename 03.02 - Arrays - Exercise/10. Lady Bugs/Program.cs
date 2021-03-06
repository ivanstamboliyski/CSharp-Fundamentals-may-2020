using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialArray.Length; i++)
            {
                for (int j = 0; j < field.Length; j++)
                {
                    if (j == initialArray[i])
                    {
                        field[j] = 1;
                        break;
                    }
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (flyLength == 0)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (direction == "right")
                {
                    int newLadybugIndex = ladybugIndex + flyLength;

                    if (newLadybugIndex < field.Length && field[newLadybugIndex] == 0)
                    {
                        field[ladybugIndex] = 0;
                        field[newLadybugIndex] = 1;
                    }
                    else
                    {
                        while (newLadybugIndex < field.Length && field[newLadybugIndex] == 1)
                        {
                            newLadybugIndex += flyLength;
                        }

                        if (newLadybugIndex < field.Length && field[newLadybugIndex] != 1)
                        {
                            field[ladybugIndex] = 0;
                            field[newLadybugIndex] = 1;
                        }
                        else
                        {
                            field[ladybugIndex] = 0;
                        }
                    }
                }
                else
                {
                    int newLadybugIndex = ladybugIndex - flyLength;

                    if (newLadybugIndex >= 0 && field[newLadybugIndex] == 0)
                    {
                        field[ladybugIndex] = 0;
                        field[newLadybugIndex] = 1;
                    }
                    else
                    {
                        while (newLadybugIndex > -1 && field[newLadybugIndex] == 1)
                        {
                            newLadybugIndex -= flyLength;
                        }

                        if (newLadybugIndex >= 0 && field[newLadybugIndex] != 1)
                        {
                            field[ladybugIndex] = 0;
                            field[newLadybugIndex] = 1;
                        }
                        else
                        {
                            field[ladybugIndex] = 0;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}