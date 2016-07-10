using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class ReferenceBook : Item
    {
        private readonly uint isbn;

        public uint ISBN
        {
            get { return isbn; }
        }

        private readonly uint pages;

        public uint Pages
        {
            get { return pages; }
        }

        public ReferenceBook()
            : base()
        {
            isbn = 0;
            pages = 0;
        }

        public ReferenceBook(uint myISBN, ushort myYear, uint myPages, string myTitle)
            : base(myTitle, myYear)
        {
            isbn = myISBN;
            pages = myPages;
        }

    }
}
