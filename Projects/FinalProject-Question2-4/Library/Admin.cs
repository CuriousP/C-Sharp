using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Admin : User
    {
        public Admin()
            : base()
        {

        }

        public Admin(string un, string pass)
            : base(un,pass)
        {
            IsAdmin = true;
        }
    }
}
