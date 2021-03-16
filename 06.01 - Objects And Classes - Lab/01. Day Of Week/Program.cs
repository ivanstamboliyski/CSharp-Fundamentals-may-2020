using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06._1.CSharpFundamentals_ObjectsAndClasses_Lab
{
    class Program
    {
        static void Main()
        {
            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
