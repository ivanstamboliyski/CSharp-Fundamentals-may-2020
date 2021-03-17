using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main()
        {
            int articlesNumber = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < articlesNumber; i++)
            {
                string[] articleData = Console.ReadLine().Split(", "); 

                Article currArticle = new Article(articleData[0], articleData[1], articleData[2]);

                articles.Add(currArticle);
            }

            string finalInput = Console.ReadLine();

            if (finalInput == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
            }
            else if (finalInput == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToList();
            }
            else
            {
                articles = articles.OrderBy(a => a.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }

        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
    
}
