using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Borrower : User
    {

        public Borrower()
            : base()
        {
            IsAdmin = false;
        }

        public Borrower(string un, string pass)
            : base(un, pass)
        {
            IsAdmin = false;
        }
    }
}
