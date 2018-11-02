using System;

namespace Midterm
{
    public class Book
    {
        public int BookID {get; set;}
        public string Title {get; set;}
        public int Pages {get; set;}
        public string Publisher{get; set;}

        public string PublishDate {get; set; }
        public int AuthorID {get; set;}

        public Author Author {get; set; }



        public override string ToString()
{
	    return $"{this.BookID} {this.Title} {this.Pages}";
}
        }
    }