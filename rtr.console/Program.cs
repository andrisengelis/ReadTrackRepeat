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

    class ReadingChallenge
    {
        public List<Book> Books { get; set; }
        public int Year { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ReadingChallenge challenge2018 = new ReadingChallenge();

            challenge2018.Year = 2019;

            challenge2018.Books = new List<Book>(){
                new Book { Title = "Killing Commendatore", Author="Haruki Murakami", Pages=927 },
                new Book { Title = "", Author="", Pages = 0}
            };


            Console.WriteLine($"You have {challenge2018.Books.Count} books in your reading list for year {challenge2018.Year}");
        }
    }
}
