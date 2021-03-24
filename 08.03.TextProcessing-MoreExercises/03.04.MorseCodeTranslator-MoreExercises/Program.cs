using System;
using System.Linq;
using System.Text;

namespace _03._04.MorseCodeTranslator_MoreExercise
{
    class Program
    {
        static void Main()
        {
            string[] morseCode = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < morseCode.Length; i++)
            {
                string[] currWord = morseCode[i].Split();

                for (int j = 0; j < currWord.Length; j++)
                {
                    switch (currWord[j])
                    {
                        case ".-":
                            result.Append("A");
                            break;
                        case "-...":
                            result.Append("B");
                            break;
                        case "-.-.":
                            result.Append("C");
                            break;
                        case "-..":
                            result.Append("D");
                            break;
                        case ".":
                            result.Append("E");
                            break;
                        case "..-.":
                            result.Append("F");
                            break;
                        case "--.":
                            result.Append("G");
                            break;
                        case "....":
                            result.Append("H");
                            break;
                        case "..":
                            result.Append("I");
                            break;
                        case ".---":
                            result.Append("J");
                            break;
                        case "-.-":
                            result.Append("K");
                            break;
                        case ".-..":
                            result.Append("L");
                            break;
                        case "--":
                            result.Append("M");
                            break;
                        case "-.":
                            result.Append("N");
                            break;
                        case "---":
                            result.Append("O");
                            break;
                        case ".--.":
                            result.Append("P");
                            break;
                        case "--.-":
                            result.Append("Q");
                            break;
                        case ".-.":
                            result.Append("R");
                            break;
                        case "...":
                            result.Append("S");
                            break;
                        case "-":
                            result.Append("T");
                            break;
                        case "..-":
                            result.Append("U");
                            break;
                        case "...-":
                            result.Append("V");
                            break;
                        case ".--":
                            result.Append("W");
                            break;
                        case "-..-":
                            result.Append("X");
                            break;
                        case "-.--":
                            result.Append("Y");
                            break;
                        case "--..":
                            result.Append("Z");
                            break;
                    }
                }

                result.Append(" ");
            }

            Console.WriteLine(result);
        }
    }
}
