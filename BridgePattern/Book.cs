using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Book: Manuscript
    {
        private string _title, _content, _author;

        public Book(IFormatter formatter)
            : base(formatter)
        {

        }

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

        public override void Print()
        {
            Console.WriteLine($"===== {_title} =====");
            Console.WriteLine($"            by {_author}");
            Console.WriteLine(_content);
        }
    }
}
