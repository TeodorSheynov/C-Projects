using System;
using System.Collections.Generic;
using System.Linq;

namespace Article2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            var articles = new List<Artic>();
            for (int i = 0; i < moves; i++)
            {
                string[] articlesArr = Console.ReadLine()
                    .Split(", ");
                string title = articlesArr[0];
                string content = articlesArr[1];
                string author = articlesArr[2];

                Artic result = new Artic(title, content, author);
                articles.Add(result);
            }
            string orderBy = Console.ReadLine();
            switch (orderBy)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title)
                        .ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content)
                        .ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author)
                        .ToList();
                    break;

                default:
                    break;
            }
            Console.WriteLine(string.Join(Environment.NewLine,articles));

        }
    }
}
