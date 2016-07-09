using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Question1
{
    public class Square : Rectangle
    {
        protected new string color;

        public new string Color
        {
            get
            {
                return this.color;
            }

            private set
            {
                this.color = value;
            }
        }

        public Square() : this("Default")
        {
        }

        public Square(string name) : this(name, 0)
        {
        }

        public Square(string name, double width) : base(name)
        {
            this.Width = width;
            this.Length = this.Width;
            this.Color = "White";
        }

        public override string ToString()
        {
            string message = base.ToString();
            message = message + "\r\nThis is a Square object called " + this.Name + " whose length is " + this.Length
                + " and width is " + this.Length + " and area is " + this.calculateArea() + " and of color " + this.Color;
            return message;
        }
    }
}
