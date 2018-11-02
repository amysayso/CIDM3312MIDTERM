using System;


namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEED DATA
            //Connect to the database and show all records in the Students Table
            seeddata.CreateSeedData();

            //LINQ WHERE
            Command.allBook();

            // Command.bookAPress();

            // Command.AuthorShortestFN();

            //LINQ FIND

            // Command.BookAdam();

            // Command.bookPG();

            //LINQ ORDER BY

            // Command.OrderByALN();

            // Command.OrderByDESC();

            //lINQ GROUP BY 

            // Command.GroupPublisher();
            // Command.GroupByP();

        }
    }
}
