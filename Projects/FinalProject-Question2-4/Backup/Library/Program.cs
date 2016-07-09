using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Program for Library Application");
            Console.WriteLine();

            Library myLib = new Library();

            // check-out one book
            myLib.book1.issue(myLib.user1);

            // try to check-out the same book by another user
            myLib.book1.issue(myLib.user2);

            // return the book
            myLib.book1.returnIt();

            // hold a book
            myLib.ebook1.holdIt(myLib.user2);

            // try to check-out the same book by another user
            myLib.ebook1.issue(myLib.user1);

            // remove hold
            myLib.ebook1.removeHolds();
            Console.WriteLine();

            // print authors
            Console.WriteLine(myLib.book1.printAuthors);
            Console.WriteLine(myLib.ebook1.printAuthors);

            Console.Read();
        }
    }
}
