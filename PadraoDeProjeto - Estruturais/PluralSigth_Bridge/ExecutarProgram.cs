using System;
using System.Collections.Generic;
using Bridge_Example.Formatter;
using Designer_Pattern.Bridge.Interfaces;
using Designer_Pattern.Bridge.Model;
namespace Designer_Pattern.Bridge
{
    public class ExecutarProgram
    {
        
      
        public static void ExecutarProgramMethod()
        {
            List<Manuscript> documents = new List<Manuscript>();
        /**
         * na variavel formatter eu posso estender vários tipos de formatter.
         */
            var formatter = new DifferentFormatter();

            var faq = new FAQ(formatter);
            faq.Title = "The Bridge Pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book(formatter)
                       {
                           Title = "Lots of Patterns",
                           Author = "John Sonmez",
                           Text = "Blah blah blah..."
                       };
            documents.Add(book);

            var paper = new TermPaper(formatter)
                        {
                            Class = "Design Patterns",
                            Student = "Joe N00b",
                            Text = "Blah blah blah...",
                            References = "GOF"
                        };
            documents.Add(paper);

            foreach(var doc in documents)
            {
                doc.Print();
            }

            Console.ReadKey();
        }
    }
}
