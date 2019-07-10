using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    interface IWriter
    {
        void Write(string text);
    }

    class Book {

        public string Text { get; }

        IWriter _writer;

        public Book(IWriter writer, string text)
        {
            _writer = writer;
            Text = text;
        }
        public void Write()
        {
            _writer.Write(Text);
        }
    }

    class FileWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            Book book = new Book(writer, "asdsadasda");

            book.Write();
            Console.ReadLine();
        }
    }
}
