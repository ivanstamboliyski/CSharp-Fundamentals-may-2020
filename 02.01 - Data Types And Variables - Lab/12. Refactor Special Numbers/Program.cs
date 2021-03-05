using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = int.Parse(Console.ReadLine());

            for (int num = 1; num <= givenNumber; num++)
            {
                int sum = 0;
                int currNum = num; 

                while (currNum > 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}", num, isSpecial);
            }
        }
    }
}
