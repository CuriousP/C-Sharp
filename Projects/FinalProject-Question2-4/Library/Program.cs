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

            // check-out one music
            myLib.music1.issue(myLib.user1);

            // try to check-out the same music by another user
            myLib.music1.issue(myLib.user2);

            //check in one music
            myLib.music1.returnIt();

            // check-out one movie
            myLib.movie1.issue(myLib.user1);

            // try to check-out the same movie by another user
            myLib.movie1.issue(myLib.user2);

            //check in one movie
            myLib.movie1.returnIt();

            // check-out one Audiobook
            myLib.audioBook1.issue(myLib.user1);

            // try to check-out the same Audiobook by another user
            myLib.audioBook1.issue(myLib.user2);

            //check in one audiobook
            myLib.audioBook1.returnIt();

            // print authors
            Console.WriteLine(myLib.book1.printAuthors);
            Console.WriteLine(myLib.ebook1.printAuthors);

            // print music duration 
            Console.WriteLine(myLib.music1.getHMS());
            Console.WriteLine(myLib.music2.getHMS());

            //print movie duration
            Console.WriteLine(myLib.movie1.getHMS());
            Console.WriteLine(myLib.movie2.getHMS());

            //print Audiobook duration
            Console.WriteLine(myLib.audioBook1.getHMS());
            Console.WriteLine(myLib.audioBook2.getHMS());

            // Print all (unsorted) elements of List<Item> using Iterator
            Console.WriteLine("\nPrint all (unsorted) elements of List<Item> using Iterator");
            foreach(Item i in Item.GetItems())
            {
                Console.WriteLine(i.ToString());
            }

            // Sort elements of List<Item> based on ‘year’
            ItemComparer itemComparer = new ItemComparer();
            Item.GetItems().Sort(itemComparer);

            // Print all (sorted) elements of List<Item> using Iterator
            Console.WriteLine("\nPrint all (sorted) elements of List<Item> using Iterator");
            foreach (Item i in Item.GetItems())
            {
                Console.WriteLine(i.ToString());
            }

            // Print all elements in dictionary collection using Indexer.
            Console.WriteLine("\nPrint all elements in dictionary collection using Indexer");
            ItemCollection myItems = new ItemCollection();
            myItems[myLib.book1.Year] = myLib.book1;
            myItems[myLib.book2.Year] = myLib.book2;
            myItems[myLib.movie1.Year] = myLib.movie1;
            myItems[myLib.movie2.Year] = myLib.movie2;
            myItems[myLib.music1.Year] = myLib.music1;
            myItems[myLib.music2.Year] = myLib.music2;

            Console.WriteLine(myItems[myLib.book1.Year]);
            Console.WriteLine(myItems[myLib.book2.Year]);
            Console.WriteLine(myItems[myLib.movie1.Year]);
            Console.WriteLine(myItems[myLib.movie2.Year]);
            Console.WriteLine(myItems[myLib.music1.Year]);
            Console.WriteLine(myItems[myLib.music2.Year]);

            // Get entries parsed from Text file.
            List<Item> parsedItems = myLib.ParseFileContents();

            // Add the parsed items to dictionary.
            // The items are also added to the List when they were initialized.
            foreach(Item i in parsedItems)
            {
                myItems[i.Year] = i;
            }

            // Call method to write the LibraryCatalog.txt
            Console.WriteLine("\nPrinted LibraryCatalog.txt in current directory");
            myLib.PrintLibraryCatalog(Item.GetItems());

            // Print Items from year 2005 using LINQ query
            Console.WriteLine("\nPrint Items from year 2005 using LINQ query");
            List<Item> result = myLib.GetItemsByYear(Item.GetItems(), 2005);
            foreach(Item i in result)
            {
                Console.WriteLine(i.ToString());
            }

            Console.Read();
        }
    }
}