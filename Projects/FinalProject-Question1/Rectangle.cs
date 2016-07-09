using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Question1
{
    public class Rectangle : Shape
    {
        protected double length;

        protected double width;

        protected new string color;

        public double Length
        {
            get
            {
                return this.length;
            }

            set
            {
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public string Color
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

        public Rectangle() : this("Default")
        {
        }

        public Rectangle(string name) : this(name, 0, 0)
        {
        }

        public Rectangle(string name, double length, double width) : base(name)
        {
            this.Length = length;
            this.Width = width;
            this.Color = "Red";
        }

        public override double calculateArea()
        {
            return this.Length * this.Width;
        }

        public override string ToString()
        {
            string message = base.ToString();
            message = message + "\r\nThis is a Rectangle object called " + this.Name + " whose length is " + this.Length
                + " and width is " + this.Width + " and area is " + this.calculateArea() + " and of color " + this.Color;
            return message;
        }
    }
}
