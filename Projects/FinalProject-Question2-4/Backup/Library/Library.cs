using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Library
    {
        // Create Users
        public Borrower user1 = new Borrower("user1", "1234");
        public Borrower user2 = new Borrower("user2", "1111");
        public Admin admin = new Admin("admin", "9999");

        // Create Authors
        public Author author1 = new Author("Smith", "John");
        public Author author2 = new Author("Brown", "Jack");

        // Add Books
        public Book book1 = new Book(1234567890, 2005, 1000, "This is book 1");
        public Book book2 = new Book(1122334455, 2006, 1500, "This is book 2");

        // Add eBooks
        public eBook ebook1 = new eBook(1234512345, 2005, 1000, "This is eBook 1", @"/eBook/book3");
        public eBook ebook2 = new eBook(1212121212, 2006, 1500, "This is eBook 2", @"/eBook/book4");

        // Add AudioBooks
        public AudioBook audioBook1 = new AudioBook(2233445566, 2005, "This is audio book 1",
            DigitalDisc.DiscType.DVD, 7200);
        public AudioBook audioBook2 = new AudioBook(3344556677, 2005, "This is audio book 2",
            DigitalDisc.DiscType.CD, 3600);

        // Add Movies
        public Movie movie1 = new Movie(2008, "This is movie 1", DigitalDisc.DiscType.BlueRay, 7200);
        public Movie movie2 = new Movie(2007, "This is movie 2", DigitalDisc.DiscType.DVD, 8000);

        // Add Music
        public Music music1 = new Music(2001, "This is music 1", DigitalDisc.DiscType.CD, 3000);
        public Music music2 = new Music(2002, "This is music 2", DigitalDisc.DiscType.DVD, 3500);

        public Library()
        {
            // set the authors
            book1.setAuthors(author1, author2);
            book2.setAuthors(author2);

            ebook1.setAuthors(author2, author1, new Author("Miller", "Julie"));
            ebook2.setAuthors(author1, author2);
        }
    }
}
