using System;

namespace _02.Articles
{
    class Program
    {
        static void Main()
        {
            string[] articleElements = Console.ReadLine().Split(",");
            int commandsNumber = int.Parse(Console.ReadLine());

            Article article = new Article(articleElements);

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] commands = Console.ReadLine().Split(":");

                if (commands[0] == "Edit")
                {
                    Article.Edit(commands);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    Article.ChangeAuthor(commands);
                }
                else
                {
                    Article.Rename(commands);
                }
            }

            Console.WriteLine(Article.PrintNewArticle());

        }
    }
    class Article 
    {
        public static string Title { get; set; }
        public static string Content  { get; set; }
        public static string Author { get; set; }

        public Article(string[] articleElements)
        {
            Title = articleElements[0];
            Content = articleElements[1];
            Author = articleElements[2];
        }

        public static void Edit(string[] commands) 
        {
            Content = commands[1];
        }
        public static void ChangeAuthor(string[] commands)
        {
            Author = commands[1];
        }
        public static void Rename(string[] commands)
        {
            Title = commands[1];
        }

        public static string PrintNewArticle()
        {
            return $"{Title} -{Content}:{Author}";
        }
    }
}
