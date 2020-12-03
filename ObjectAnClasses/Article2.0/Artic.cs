using System;
using System.Collections.Generic;
using System.Text;

namespace Article2._0
{
    class Artic
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Artic(string title,string content, string author)
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
