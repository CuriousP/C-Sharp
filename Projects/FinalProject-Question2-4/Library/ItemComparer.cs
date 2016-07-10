using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class ItemComparer : IComparer<Item>
    {        
        public int Compare(Item x, Item y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    return x.Year.CompareTo(y.Year);
                }
            }
        }        
    }
}
