using System;

namespace Midterm
{
    public class Author
    {
        public int AuthorID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
       
    
        public override string ToString()
            {
	            return $"{this.AuthorID} {this.FirstName}";
            }
        }
    }
