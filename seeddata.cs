using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Midterm
{
    public class seeddata
    {
        
        public static void CreateSeedData() {
            using (var context = new AppDbContext()) {

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();



                if(!context.Author.Any()) {
                    List<Author> author = new List<Author>(){
                        new Author(){
                            AuthorID = 1,
                            FirstName = "Adam",
                            LastName = "Freeman"

                        },

                        new Author(){
                            AuthorID = 2,
                            FirstName = "Haishi",
                            LastName = "Bai"

                        }
                    };

                        context.Author.AddRange(author);
                        context.SaveChanges();

                if(!context.Book.Any()) {
                    List<Book> book = new List<Book>() {
                        new Book() {
                            Title = "Pro ASP.NET Core MVC 27th ed. Edition",
                            Publisher = "Apress",
                            PublishDate = "October 25, 2017",
                            AuthorID = 1,
                            Pages = 1017
                            
                        },
                        new Book() {
                            Title = "Pro Angular 6 3rd Edition",
                            Publisher = "Apress",
                            PublishDate = "October 10, 2018",
                            AuthorID = 1,
                            Pages = 776
                        },    
                        new Book() {
                            Title = "Programming Microsoft Azure Service Fabric (Developer Reference) 2nd Edition",
                            Publisher = "Microsoft Press",
                            PublishDate = "May 25, 2018",
                            AuthorID = 2,
                            Pages = 528   

                    }
                    };

                    context.Book.AddRange(book);  
                    context.SaveChanges();  
                }
            } 
        }
    }
}
}