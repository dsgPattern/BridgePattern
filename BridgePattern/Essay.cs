using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class Essay: IManuscript
    {
        private string _student, _topic, _text;

        public Essay SetStudentName(string name)
        {
            _student = name;
            return this;
        }

        public Essay SetTopic(string topic)
        {
            _topic = topic;
            return this;
        }

        public Essay SetText(string text)
        {
            _text = text;
            return this;
        }


        public void Print()
        {
            Console.WriteLine($"Essay of {_student} on the subject of {_topic}");
            Console.WriteLine(_text);
        }
    }
}
