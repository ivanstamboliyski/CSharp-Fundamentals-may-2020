using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main()
        {
            int snowballsCount = int.Parse(Console.ReadLine());

            BigInteger biggestSnowballValue = int.MinValue;

            string result = "";

            for (int snowball = 1; snowball <= snowballsCount; snowball++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue >= biggestSnowballValue)
                {
                    biggestSnowballValue = snowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
 
                }
            }

            Console.WriteLine(result);
        }
    }
}
