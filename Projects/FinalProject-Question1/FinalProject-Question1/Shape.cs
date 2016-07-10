using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Question1
{
    public abstract class Shape
    {
        private static int count;

        protected string name;

        protected string color;

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public Shape() : this("Default")
        {
        }

        public Shape(string name)
        {
            count++;
            this.Name = name;
            this.color = "Black";
            Console.WriteLine("Shape called " + name + " created");
        }

        public abstract double calculateArea();

        public override string ToString()
        {
            string message = count + " This is a Shape object called " + this.Name;
            return message;
        }
    }
}
