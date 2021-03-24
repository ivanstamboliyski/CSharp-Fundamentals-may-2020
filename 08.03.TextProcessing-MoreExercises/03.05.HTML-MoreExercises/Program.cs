using System;
using System.Linq;
using System.Text;

namespace _03._05.HTML_MoreExercise
{
    class Program
    {
        static void Main()
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment;

            StringBuilder result = new StringBuilder();
            result.AppendLine("<h1>");
            result.AppendLine($"    {title}");
            result.AppendLine("</h1>");
            result.AppendLine("<article>");
            result.AppendLine($"    {content}");
            result.AppendLine("</article>");

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                result.AppendLine("<div>");
                result.AppendLine($"    {comment}");
                result.AppendLine("</div>");
            }

            Console.WriteLine(result);
        }
    }
}
