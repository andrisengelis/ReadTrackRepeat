using System;
using System.Collections.Generic;

namespace rtr.console
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> YearChallange = new List<Book>();

            Console.WriteLine("Hello World!");
        }
    }
}
