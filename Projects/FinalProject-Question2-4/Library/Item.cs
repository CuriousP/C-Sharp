using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Item : IComparable<Item>
    {
        protected string title;
        protected ushort year;
        private Author[] authors = new Author[500];
        private static List<Item> itemList = new List<Item>();

        public ushort Year
        {
            get
            {
                return this.year;
            }
        }

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

        public static void SetItem(Item item)
        {
            itemList.Add(item);
        }

        public static List<Item> GetItems()
        {
            return itemList;
        }

        public Item()
        {
            title = String.Empty;
            year = 0;
            authors[0] = new Author();
            itemList.Add(this);
        }

        public Item(string t, ushort y)
        {
            title = t;
            year = y;
            itemList.Add(this);  
        }

        public void setAuthors(params Author[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                authors.SetValue(a[i], i);
            }
        }

        #region IComparable implementation
        public int CompareTo(Item i)
        {
            return this.year - i.year;
        }
        #endregion        

        public override string ToString()
        {
            return "Item: Year-" + this.year + ", Title- " + this.title;
        }

        public virtual string ToTextFormat()
        {
            return "Item: Year-" + this.year + ", Title- " + this.title;
        }
    }
}