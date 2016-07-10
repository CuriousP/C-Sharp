using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class User
    {
        private string uName;

        public string UserName
        {
            get { return uName; }
            set { uName = value; }
        }
        private string passwd;

        public string Password
        {
            get { return passwd; }
            set { passwd = value; }
        }
        private bool isAdmin = false;

        protected bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public DateTime memberSince { get; set; }
        public DateTime lastLogin { get; set; }

        public User()
        {
            uName = String.Empty;
            passwd = String.Empty;
        }

        public User(string un, string pass)
        {
            uName = un;
            passwd = pass;
        }

    }
}
