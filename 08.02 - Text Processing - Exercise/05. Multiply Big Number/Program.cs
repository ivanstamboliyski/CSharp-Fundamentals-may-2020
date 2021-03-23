using System;

namespace _02._05.Multiply_Big_Number__Exercise
{
    class Program
    {
        static void Main()
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());

            string result = string.Empty;
            int additive = 0;

            if (num == 0)
            {
                Console.WriteLine("0"); ;
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currSymbol = int.Parse(bigNumber[i].ToString()) * num;
                currSymbol += additive;

                if (currSymbol <= 9)
                {
                    result = currSymbol.ToString()[0].ToString() + result;
                    additive = 0;
                    continue;
                }

                result = currSymbol.ToString()[1].ToString() + result;

                additive = int.Parse(currSymbol.ToString()[0].ToString());

            }

            if (additive > 0)
            {
                result = additive.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
