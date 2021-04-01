using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._02.FancyBarcodes__04._04._2020_Group_2
{
    class Program
    {
        static void Main()
        {
            int barcodesCount = int.Parse(Console.ReadLine());

            string mainPattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

            for (int barcode = 0; barcode < barcodesCount; barcode++)
            {
                string currBarcode = Console.ReadLine();

                Match match = Regex.Match(currBarcode, mainPattern);

                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    MatchCollection digits = Regex.Matches(currBarcode, "[0-9]");
                    string productGroup = String.Concat(digits);

                    if (digits.Count == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
            }
        }
    }
}
