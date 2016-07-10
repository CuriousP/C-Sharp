using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class Author
    {
        private string lastName;
        private string firstName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public Author()
        {
            lastName = String.Empty;
            firstName = String.Empty;
        }

        public Author(string last, string first)
        {
            lastName = last;
            firstName = first;
        }
    }
}
