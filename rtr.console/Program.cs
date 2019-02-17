﻿using System;
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
        public List<Book> ReadingList { get; set; }
        public List<Book> BooksCompleted { get; set; }
        public int Year { get; set; }
        public int Goal { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ReadingChallenge challenge = new ReadingChallenge();

            challenge.Year = 2019;
            challenge.Goal = 24;

            challenge.ReadingList = new List<Book>(){
                new Book { Title = "Killing Commendatore", Author = "Haruki Murakami", Pages = 927 },
                new Book { Title = "Fall, or Dodge in Hell", Author = "Neal Stephenson", Pages = 720 },
                new Book { Title = "White Shadow", Author = "Roy Jacobsen", Pages = 272 },
                new Book { Title = "Red Moon", Author = "Kim Stanley Robinson", Pages = 464 },
                new Book { Title = "Summerland", Author = "Hannu Rajaniemi", Pages = 336 },
                new Book { Title = "Diaspora", Author = "Greg Egan", Pages = 352 }

            };
            challenge.BooksCompleted = new List<Book>();

            Console.WriteLine($"This reading challenge is for year {challenge.Year}");
            Console.WriteLine($"You have commited to read {challenge.Goal} books.");
            Console.WriteLine($"You have completed {challenge.BooksCompleted.Count} books.");
            Console.WriteLine($"You have {challenge.ReadingList.Count} books in your reading list");
        }
    }
}
