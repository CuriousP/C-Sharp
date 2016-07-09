using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Question1
{
    public class Circle : Shape
    {
        protected int radius;

        protected new string color;

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

        public int Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                this.radius = value;
            }
        }

        public Circle() : this("Default")
        {
        }

        public Circle(string name) : this(name, 0)
        {
        }

        public Circle(string name, int radius) : base(name)
        {
            this.Radius = radius;
            this.Color = "Blue";
        }

        public override double calculateArea()
        {
            return 3.14 * this.Radius * this.Radius;
        }

        public override string ToString()
        {
            string message = base.ToString();
            message = message + "\r\nThis is a Circle object called " + this.Name + " whose radius is " + this.Radius +
                " and area is " + this.calculateArea() + " and of color " + this.Color;
            return message;
        }
    }
}
