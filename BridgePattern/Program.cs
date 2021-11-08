using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book(new MirrorFormater())
                .SetAuthor("Ion Creanga")
                .SetTitle("Amintiri din copilarie")
                .SetContent("Povestea lui Ion ....");

            var faq = new FAQ(new MirrorFormater())
                .SetSubject("Design patterns")
                .AddQuestion("Ce sunt design patterns?")
                .AddQuestion("Care sunt principalele categorii?")
                .AddQuestion("La ce folosesc?");

            var essay = new Essay(new MirrorFormater())
                .SetStudentName("John Doe")
                .SetTopic("Despre orice")
                .SetText("Text random");

            book.Print();
            Console.WriteLine();
            faq.Print();
            Console.WriteLine();
            essay.Print();


            //TODO: cum printam invers, in oglinda, ca pentru o coperta de carte, unde jumate e printat ok si jumate in oglinda?
            // Mai adaugam un nivel de abstractie: un formatter care e setat in fiecare clasa manuscript
            Console.ReadLine();
        }
    }
}
