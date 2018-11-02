using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Midterm
{
    public class Command 
    {
      //LINQ Where Method 

      //1) Show all records in the Books table, print this to the Console
        public static void allBook()
        {
            using(var db = new AppDbContext())
            {
                 var books = db.Book;
                 //var allBook =  books.Where( b => b.Title == "A Title");
                foreach ( var book in books)
                {
                 Console.WriteLine(books);
                }

            }
        }


        //2) show all records of Books published by "APress"
        public static void bookAPress()
        {
            using(var db = new AppDbContext())
            {
                var book = db.Book;
                var bookAPress = book.Where (b => b.Publisher == "Apress");
                
                foreach (var b in bookAPress)
                    {
                        Console.WriteLine(b);
                    }
            }
        }

        //3) show all records of Books whose author's first name is the shortest

        public static void AuthorShortestFN()
        {
            using (var db = new AppDbContext())
            {
                var author = db.Author;
                var AuthorShortestFN = from a in author
                                       orderby a.FirstName.Length
                                       select a;

                
                    Console.WriteLine(AuthorShortestFN);
                
            }
        }


        //LINQ Find method 

        //1) find the first book by an author named "Adam" and print that reocrd to the screen
        public static void BookAdam()
        {
            using (var db = new AppDbContext())
            {
                var a = db.Author;
                var BookAdam = a.Where(b => b.FirstName == "Adam");

                
                    Console.WriteLine(BookAdam);
                
            }
        }

        //2) find the first book whose page count is greather than 1000
        public static void bookPG()
        {
            using(var db = new AppDbContext())
            {
                var b = db.Book;
                var bookPG = b.Where(a => a.Pages > 1000);

                foreach (var p in bookPG)
                {
                Console.WriteLine(p);
                }
            }
        }

        //LINQ OrderByMethod

        //1) show all Books sorted by Author's Last name

            public static void OrderByALN()
            {
                using(var db = new AppDbContext())
                {
                    var orderedLastName = db.Author.OrderBy(l => l.LastName);
                    foreach (var o in orderedLastName)
                    {
                    Console.WriteLine(orderedLastName);
                    }

                }
            }

        //2) show all Books sorted by book title descending 
        public static void OrderByDESC()
        {
            using(var db = new AppDbContext())
            {
                var OrderedBookTitle = from b in db.Book
                                       orderby b.Title descending
                                       select b;
                foreach (var bt in OrderedBookTitle){
                Console.WriteLine(OrderedBookTitle);
                }
            }
        }

        //LINQ GroupBy and OrderBy Methods

        //1) show all Books grouped by publisher 
        public static void GroupPublisher()
        {
            using (var db = new AppDbContext())
            {
                var book = db.Book;
                var publisher = book.GroupBy(g => g.Publisher);

                foreach ( var p in publisher)
                {
                Console.WriteLine(p);
                }
            }
        }


        //2) show all Books Grouped by publisher and sorted by author's last name 
        public static void GroupByP()
        {
            using (var db = new AppDbContext())
            {
                var book = db.Book;
                var bookWriter = db.Author; 
                //var publisher = bookWriter.OrderBy (l => l.LastName);
                var innerJoin = from b in db.Book 
                                join a in db.Author
                                on b.AuthorID equals a.AuthorID
                                select new {
                                    AuthorID = a.AuthorID,
                                    FirstName = a.FirstName,
                                    LastName = a.LastName,
                                    Title = b.Title,
                                    Publisher = b.Publisher,
                                    DatePublished = b.PublishDate,
                                    NumOfPages = b.Pages

                                };
                

                var orderedTables = innerJoin.OrderBy(p => p.LastName).GroupBy(r => r.Publisher);
                                

                foreach(var p in orderedTables)
                {
                    Console.WriteLine($"------Group by {p.Key} --------\n");
                    foreach (var a in p)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        
        }

    }
}


