using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Book: IManuscript
    {
        private string _title, _content, _author;

        public Book SetTitle(string title)
        {
            _title = title;
            return this;
        }

        public Book SetAuthor(string author)
        {
            _author = author;
            return this;
        }

        public Book SetContent(string content)
        {
            _content = content;
            return this;
        }

        public void Print()
        {
            Console.WriteLine($"===== {_title} =====");
            Console.WriteLine($"            by {_author}");
            Console.WriteLine(_content);
        }
    }
}
