using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Book : Item, Iloanable
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

        public Book()
            : base()
        {
            isbn = 0;
            pages = 0;
            isAvailable = false;
            isOnHold = false;
        }

        public Book(uint myISBN, ushort myYear, uint myPages, string myTitle)
            : base(myTitle,myYear)
        {
            isbn = myISBN;
            pages = myPages;
            isAvailable = true;
            isOnHold = false;
        }

        #region Iloanable Members

        public User currentUser { get; set; }

        public DateTime checkOutTime { get; set; }

        public DateTime checkInTime { get; set; }

        public bool isAvailable { get; set; }

        public bool isOnHold { get; set; }

        public void issue(User u)
        {
            if (isAvailable)
            {
                currentUser = u;
                checkOutTime = DateTime.Now;
                checkInTime = DateTime.MinValue;
                isAvailable = false;
                isOnHold = false;
                Console.WriteLine(ISBN + " is issued to " + currentUser.UserName + " at " + checkOutTime);

            }
            else
            {
                Console.WriteLine(ISBN + " is not available to check-out");
            }
        }

        public void returnIt()
        {
            if (!isAvailable)
            {
                checkInTime = DateTime.Now;
                Console.WriteLine(ISBN + " is returned by " + currentUser.UserName + " at " + checkInTime);
                currentUser = null;
                isAvailable = true;
                isOnHold = false;
            }
            else
            {
                Console.WriteLine("This item is not checked-out yet");
            }
        }

        public void holdIt(User u)
        {
            if (isAvailable && !isOnHold)
            {
                currentUser = u;
                isAvailable = false;
                isOnHold = false;
                checkOutTime = DateTime.Now;
                Console.WriteLine(ISBN + " is on hold for " + currentUser.UserName + " at " + checkOutTime);
            }
            else
            {
                Console.WriteLine("This item can not be put on hold");
            }
        }

        public void removeHolds()
        {
            if (!isAvailable && isOnHold)
            {
                currentUser = null;
                isAvailable = true;
                isOnHold = false;
                checkOutTime = DateTime.MaxValue;
                Console.WriteLine("Hold is removed");
            }
            else
            {
                Console.WriteLine("This item is not on hold");
            }
        }

        #endregion

    }
}
