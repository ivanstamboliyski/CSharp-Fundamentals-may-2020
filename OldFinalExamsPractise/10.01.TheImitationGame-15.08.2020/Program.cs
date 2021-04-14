using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace RetakeFinalExam_CSharpFundamentals_15._08._2020
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();

            string instructions;

            while ((instructions = Console.ReadLine()) != "Decode")
            {
                string operation = instructions.Split('|')[0];

                switch (operation)
                {
                    case "Move":
                        int lettersNumber = int.Parse(instructions.Split('|')[1]);
                        string firstNElements = message.Substring(0, lettersNumber);
                        message = message.Remove(0, lettersNumber);
                        message += firstNElements;
                        break;

                    case "Insert":
                        int givenIndex = int.Parse(instructions.Split('|')[1]);
                        string value = instructions.Split('|')[2];
                        message = message.Insert(givenIndex, value);
                        break;

                    case "ChangeAll":
                        string substring = instructions.Split('|')[1];
                        string replacement = instructions.Split('|')[2];
                        message = message.Replace(substring, replacement);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
