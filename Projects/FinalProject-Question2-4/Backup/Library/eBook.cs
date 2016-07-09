using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class eBook : Book
    {
        private string filePath = String.Empty;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public eBook()
            : base()
        {
            filePath = String.Empty;
        }

        public eBook(uint myISBN, ushort myYear, uint myPages, string myTitle, string fileP)
            : base(myISBN, myYear, myPages, myTitle)
        {
            filePath = fileP;
        }
    }
}
