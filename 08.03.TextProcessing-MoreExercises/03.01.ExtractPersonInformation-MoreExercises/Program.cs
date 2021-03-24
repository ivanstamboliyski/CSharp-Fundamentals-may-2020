using System;
using System.Linq;
using System.Text;


namespace _03._01.ExtractPersonInformation_MoreExercise
{
    class Program
    {
        static void Main()
        {
            int linesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesNumber; i++)
            {
                string text = Console.ReadLine();

                string name = text.Substring(text.IndexOf('@') + 1, text.IndexOf('|') - text.IndexOf('@') - 1);
                string age = text.Substring(text.IndexOf('#') + 1, text.IndexOf('*') - text.IndexOf('#') - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
