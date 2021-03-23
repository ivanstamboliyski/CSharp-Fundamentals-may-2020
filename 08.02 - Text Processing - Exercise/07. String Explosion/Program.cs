using System;
using System.Text;

namespace _02._07.StringExplosion_Exercise
{
    class Program
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());

            int explosionStrength = 0;
            int initialLenght = input.Length;

            for (int i = 0; i < initialLenght; i++)
            {
                if (explosionStrength > 0)
                {
                    while (explosionStrength > 0 && i < input.Length)                 // abv>1>1>2>2asdasd
                    {
                        if (input[i] == '>')
                        {
                            explosionStrength += int.Parse(input[i + 1].ToString());
                            i++;
                        }

                        input = input.Remove(i, 1);
                        explosionStrength--;
                    }
                }

                if (i >= input.Length)
                {
                    break;
                }

                if (input[i] == '>' && i + 1 < input.Length)
                {
                    explosionStrength = int.Parse(input[i + 1].ToString());
                }
            }

            Console.WriteLine(input);
        }
    }
}
