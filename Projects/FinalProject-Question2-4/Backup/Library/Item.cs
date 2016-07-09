using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Item
    {
        protected string title;
        protected ushort year;
        private Author[] authors = new Author[500];

        public string printAuthors
        {
            get 
            {
                string s = String.Empty;
                int i = 0;
                while (authors[i] != null)
                {
                    if (i > 0)
                    {
                        s += "; ";
                    }
                    s += authors[i].LastName + ", " + authors[i].FirstName;
                    i++;
                }
                return s;
            }
        }

        public Item()
        {
            title = String.Empty;
            year = 0;
            authors[0] = new Author();
        }

        public Item(string t, ushort y)
        {
            title = t;
            year = y;
        }

        public void setAuthors(params Author[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                authors.SetValue(a[i], i);
            }
        }

    }
}
