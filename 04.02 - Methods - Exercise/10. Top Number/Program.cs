using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            FindAllTopNumbersInRange(num);
        }
        static void FindAllTopNumbersInRange(int num) 
        {
            for (int i = 1; i <= num; i++)
            {
                if (SumDigitsOFCurrentNum(i) % 8 == 0 && FindIfCurrNumContainsAtLeastOneOdd(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static int SumDigitsOFCurrentNum(int currNum) 
        {
            int[] currNumDigits = new int[currNum.ToString().Length];
            int sum = 0;

            for (int i = 0; i < currNumDigits.Length; i++)
            {
                currNumDigits[i] = currNum % 10;
                currNum /= 10;
            }

            for (int i = 0; i < currNumDigits.Length; i++)
            {
                sum += currNumDigits[i];
            }

            return sum;
        }
        static bool FindIfCurrNumContainsAtLeastOneOdd(string currNum) 
        {
            bool containsOdd = false;

            for (int i = 0; i < currNum.Length; i++)
            {
                if (currNum[i] % 2 != 0)
                {
                    containsOdd = true;
                    break;
                }
            }

            return containsOdd;
        }
    }
}
