using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinalExams_Practise_ProgramingFundamentalsMay2020
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine().Trim();

            string operations;

            while ((operations = Console.ReadLine()) != "Reveal")
            {
                string command = operations.Split(":|:", StringSplitOptions.RemoveEmptyEntries)[0].Trim();

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(operations.Split(":|:")[1]);
                        message = message.Insert(index, " ");
                        break;

                    case "Reverse":
                        string substring = operations.Split(":|:")[1];

                        if (message.Contains(substring))
                        {
                            char[] cutted = message.Substring(message.IndexOf(substring), substring.Length).ToCharArray();
                            Array.Reverse(cutted);
                            message = message.Remove(message.IndexOf(substring), substring.Length);
                            message += new string(cutted);
                        }
                        else
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        break;

                    case "ChangeAll":
                        substring = operations.Split(":|:")[1];
                        string replacement = operations.Split(":|:")[2];
                        message = message.Replace(substring, replacement);
                        break;
                }

                Console.WriteLine(message);
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
