using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book(new DefaultFormatter())
                .SetAuthor("Ion Creanga")
                .SetTitle("Amintiri din copilarie")
                .SetContent("Povestea lui Ion ....");

            var faq = new FAQ(new MirrorFormater())
                .SetSubject("Design patterns")
                .AddQuestion("Ce sunt design patterns?")
                .AddQuestion("Care sunt principalele categorii?")
                .AddQuestion("La ce folosesc?");

            var essay = new Essay(new AllCapsFormatter())
                .SetStudentName("John Doe")
                .SetTopic("Despre orice")
                .SetText("Text random");

            book.Print();
            Console.WriteLine();
            faq.Print();
            Console.WriteLine();
            essay.Print();

            Console.ReadLine();
        }
    }
}
