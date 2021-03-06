using System;

namespace _03._3.CSharpFundamentals_Arrays_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = int.Parse(Console.ReadLine());

            int[] stringsArr = new int[arrayLenght];

            for (int i = 0; i < stringsArr.Length; i++)
            {
                string currString = Console.ReadLine();
                int stringSum = 0;

                for (int j = 0; j < currString.Length; j++)
                {
                    if (currString[j] == 'a' || currString[j] == 'e' || currString[j] == 'i' || currString[j] == 'o' || currString[j] == 'u' || currString[j] == 'A' || currString[j] == 'E' || currString[j] == 'I' || currString[j] == 'O' || currString[j] == 'U')
                    {
                        stringSum += currString[j] * currString.Length;
                    }
                    else
                    {
                        stringSum += currString[j] / currString.Length;
                    }
                }
                stringsArr[i] = stringSum;
            }

            //      Method 1

            //  Array.Sort(stringsArr);

            //      Method 2

            //Array.Sort<int>(stringsArr, new Comparison<int>(
            //      (i1, i2) => i1.CompareTo(i2)));

            //      Method 3

            int temp;

            for (int i = 0; i < stringsArr.Length - 1; i++) 
            {
                for (int j = i + 1; j < stringsArr.Length; j++) 
                {
                    if (stringsArr[i] > stringsArr[j])
                    {
                        temp = stringsArr[i];
                        stringsArr[i] = stringsArr[j];
                        stringsArr[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join("\n", stringsArr));
        }
    }
}
