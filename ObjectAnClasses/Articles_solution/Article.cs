using System;
using System.Collections.Generic;
using System.Text;

namespace Articles_solution
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string x)
        {
            Content = x;
        }
        public void ChangeAuthor(string x)
        {
            Author = x;
        }
        public void Rename(string x)
        {
            Title = x;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
