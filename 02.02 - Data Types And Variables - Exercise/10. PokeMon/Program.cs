using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetsCounter = 0;
            int currPower = pokePower;

            while (currPower >= distance)
            {
                currPower -= distance;
                targetsCounter++;

                if (currPower == pokePower * 0.50)
                {
                    if (exhaustionFactor != 0)
                    {
                        currPower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(currPower);
            Console.WriteLine(targetsCounter);
        }
    }
}
