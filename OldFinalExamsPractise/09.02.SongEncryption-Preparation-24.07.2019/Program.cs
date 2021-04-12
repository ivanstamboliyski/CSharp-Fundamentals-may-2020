using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _10._02.SongEncryption_Preparation_24._07._2019
{
    class Program
    {
        static void Main()
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                Regex regex = new Regex("^(?<artist>[A-Z][a-z ']+):(?<song>[A-Z ]+)$");
                Match validInput = regex.Match(input);

                if (!validInput.Success)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int key = validInput.Groups["artist"].Length;

                string inputAsString = validInput.ToString();
                StringBuilder encrypted = new StringBuilder();

                for (int symbol = 0; symbol < inputAsString.Length; symbol++)
                {
                    if (inputAsString[symbol] == ':')
                    {
                        encrypted.Append('@');
                    }
                    else if (Char.IsLetter(inputAsString[symbol]))
                    {
                        if (char.IsUpper(inputAsString[symbol]))
                        {
                            char resultChar = (char)(inputAsString[symbol] + key);

                            if (resultChar > 'Z')
                            {
                                resultChar = (char)('A' + (key - ('Z' - inputAsString[symbol] + 1)));
                            }

                            encrypted.Append(resultChar);
                        }
                        else
                        {
                            char resultChar = (char)(inputAsString[symbol] + key);

                            if (resultChar > 'z')
                            {
                                resultChar = (char)('a' + (key - ('z' - inputAsString[symbol] + 1)));
                            }

                            encrypted.Append(resultChar);
                        }
                    }
                    else
                    {
                        encrypted.Append(inputAsString[symbol]);
                    }
                }

                Console.WriteLine($"Successful encryption: {encrypted}");
                encrypted.Clear();
            }
        }
    }
}
