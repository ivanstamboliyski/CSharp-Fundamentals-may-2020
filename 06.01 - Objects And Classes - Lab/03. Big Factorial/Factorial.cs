using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _03.BigFactorial
{
    public class Factorial
    {
        public static BigInteger CalculateFactorial(int n)
        {
            BigInteger result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
