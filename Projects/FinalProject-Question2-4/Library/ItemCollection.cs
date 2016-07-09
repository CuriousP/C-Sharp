using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class ItemCollection : IEnumerable
    {
        private Dictionary<ushort, Item> listItem = new Dictionary<ushort, Item>();

        public Item this[ushort year]
        {
            get { return listItem[year]; }
            set { listItem[year] = value; }
        }

        public ItemCollection()
        {
        }

        public void ClearPeople()
        { listItem.Clear(); }

        public int Count
        { get { return listItem.Count; } }

        // Foreach enumeration support. 
        IEnumerator IEnumerable.GetEnumerator()
        { return listItem.GetEnumerator(); }
    }
}
