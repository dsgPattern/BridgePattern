using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BridgePattern
{
    public class FAQ: IManuscript
    {
        private string _subject;
        private List<string> _questions = new List<string>();

        public FAQ SetSubject(string subject)
        {
            _subject = subject;
            return this;
        }

        public FAQ AddQuestion(string question)
        {
            _questions.Add(question);
            return this;
        }

        public void Print()
        {
           Console.WriteLine($"{_subject}:");
           foreach (var question in _questions)
           {
               Console.WriteLine(question);
           }
        }
    }
}
