using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        public List<Item> ParseFileContents()
        {
            List<Item> parsedItems = new List<Item>();
            string bookPattern = @"Type:\sBook\sYear:\s(\d{4})\sTitle:\s(.*)\sISBN:(\d{10})\sPages:\s(.*)\sAuthors:(.*)";
            string eBookPattern = @"Type:\seBook\sYear:\s(\d{4})\sTitle:\s(.*)\sISBN:(\d{10})\sPages:\s(.*)\sAuthors:(.*)File:(.*)";
            string audioBookPattern = @"Type:\sAudioBook\sYear:\s(\d{4})\sTitle:\s(.*)\sISBN:(\d{10})\sDiscType:(CD|DVD|BlueRay)\sSeconds:(.*)";
            string musicPattern = @"Type:\sMusic\sYear:\s(\d{4})\sTitle:\s(.*)\sDiscType:(CD|DVD|BlueRay)\sSeconds:(.*)";
            string moviePattern = @"Type:\sMovie\sYear:\s(\d{4})\sTitle:\s(.*)\sDiscType:(CD|DVD|BlueRay)\sSeconds:(.*)";

            Regex bookRegex = new Regex(bookPattern);
            Regex eBookRegex = new Regex(eBookPattern);
            Regex audioBookRegex = new Regex(audioBookPattern);
            Regex musicRegex = new Regex(musicPattern);
            Regex movieRegex = new Regex(moviePattern);

            using (StreamReader r = new StreamReader("LibraryCatalog-Input.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {                    
                    Match m = bookRegex.Match(line);
                    if (m.Success)
                    {                        
                        string year = m.Groups[1].Value.Trim();
                        string title = m.Groups[2].Value.Trim();
                        string isbn = m.Groups[3].Value.Trim();
                        string pages = m.Groups[4].Value.Trim();
                        string authors = m.Groups[5].Value.Trim();
                        
                        Book myBook = new Book(Convert.ToUInt32(isbn), Convert.ToUInt16(year), Convert.ToUInt16(pages), title);

                        string[] authorTokens = authors.Split(';');
                        foreach (string author in authorTokens)
                        {
                            string[] authorDetails = author.Split(',');
                            myBook.setAuthors(new Author(authorDetails[0], authorDetails[1]));
                        }
                        parsedItems.Add(myBook);
                        continue;
                    }

                    m = eBookRegex.Match(line);
                    if (m.Success)
                    {
                        string year = m.Groups[1].Value.Trim();
                        string title = m.Groups[2].Value.Trim();
                        string isbn = m.Groups[3].Value.Trim();
                        string pages = m.Groups[4].Value.Trim();
                        string authors = m.Groups[5].Value.Trim();
                        string file = m.Groups[6].Value.Trim();
                        eBook myEbook = new eBook(Convert.ToUInt32(isbn), Convert.ToUInt16(year), Convert.ToUInt16(pages), title, file);

                        string[] authorTokens = authors.Split(';');
                        foreach (string author in authorTokens)
                        {
                            string[] authorDetails = author.Split(',');
                            myEbook.setAuthors(new Author(authorDetails[0], authorDetails[1]));
                        }
                        parsedItems.Add(myEbook);
                        continue;
                    }

                    m = audioBookRegex.Match(line);
                    if (m.Success)
                    {
                        string year = m.Groups[1].Value.Trim();
                        string title = m.Groups[2].Value.Trim();
                        string isbn = m.Groups[3].Value.Trim();
                        string discType = m.Groups[4].Value.Trim();
                        string seconds = m.Groups[5].Value.Trim();

                        DigitalDisc.DiscType dType = GetDiscType(discType);                        

                        AudioBook myAudioBook = new AudioBook(Convert.ToUInt32(isbn), Convert.ToUInt16(year), title,
                            dType, Convert.ToUInt16(seconds));

                        parsedItems.Add(myAudioBook);
                        continue;
                    }

                    m = musicRegex.Match(line);
                    if (m.Success)
                    {
                        string year = m.Groups[1].Value.Trim();
                        string title = m.Groups[2].Value.Trim();                        
                        string discType = m.Groups[3].Value.Trim();
                        string seconds = m.Groups[4].Value.Trim();

                        DigitalDisc.DiscType dType = GetDiscType(discType);
                        Music myMusic = new Music(Convert.ToUInt16(year), title, dType, Convert.ToUInt16(seconds));

                        parsedItems.Add(myMusic);
                        continue;
                    }

                    m = movieRegex.Match(line);
                    if (m.Success)
                    {
                        string year = m.Groups[1].Value.Trim();
                        string title = m.Groups[2].Value.Trim();
                        string discType = m.Groups[3].Value.Trim();
                        string seconds = m.Groups[4].Value.Trim();

                        DigitalDisc.DiscType dType = GetDiscType(discType);
                        Movie myMusic = new Movie(Convert.ToUInt16(year), title, dType, Convert.ToUInt16(seconds));

                        parsedItems.Add(myMusic);
                        continue;
                    }
                }
            }

            return parsedItems;
        }

        public List<Item> GetItemsByYear(List<Item> itemList, ushort year)
        {
            return itemList.Where<Item>(x => x.Year == year).ToList<Item>();
        }

        public void PrintLibraryCatalog(List<Item> itemList)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"LibraryCatalog.txt"))
            {
                foreach (Item i in itemList)
                {
                    file.WriteLine(i.ToTextFormat());
                }
            }
        }

        private DigitalDisc.DiscType GetDiscType(string discType)
        {
            DigitalDisc.DiscType dType = DigitalDisc.DiscType.CD;
            if (discType.Equals(DigitalDisc.DiscType.BlueRay.ToString()))
            {
                dType = DigitalDisc.DiscType.BlueRay;
            }
            else if (discType.Equals(DigitalDisc.DiscType.DVD.ToString()))
            {
                dType = DigitalDisc.DiscType.DVD;
            }
            else if (discType.Equals(DigitalDisc.DiscType.CD.ToString()))
            {
                dType = DigitalDisc.DiscType.CD;
            }

            return dType;
        }
    }
}
