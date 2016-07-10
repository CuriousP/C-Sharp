using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle();
            Circle circleB = new Circle("Circle-B");
            Circle circleC = new Circle("Circle-C", 5);
            Rectangle rectangleA = new Rectangle();
            Rectangle rectangleB = new Rectangle("Rectangle-B");
            Rectangle rectangleC = new Rectangle("Rectangle-C", 5, 8);
            Square squareA = new Square();
            Square squareB = new Square("Square-B");
            Square squareC = new Square("Square-C", 5);
            Console.WriteLine();
            Console.WriteLine(circleA);
            Console.WriteLine(circleB);
            Console.WriteLine(circleC);
            Console.WriteLine();
            Console.WriteLine(rectangleA);
            Console.WriteLine(rectangleB);
            Console.WriteLine(rectangleC);
            Console.WriteLine();
            Console.WriteLine(squareA);
            Console.WriteLine(squareB);
            Console.WriteLine(squareC);
            Console.WriteLine();
            Console.WriteLine(circleA.Name + "\t" + circleA.Radius + " has area: " + circleA.calculateArea() + "\t" + circleA.Color);
            Console.WriteLine(circleB.Name + "\t" + circleB.Radius + " has area: " + circleB.calculateArea() + "\t" + circleB.Color);
            Console.WriteLine(circleC.Name + "\t" + circleC.Radius + " has area: " + circleC.calculateArea() + "\t" + circleC.Color);
            Console.WriteLine();
            Console.WriteLine(rectangleA.Name + "\t" + rectangleA.Width + "\t" + rectangleA.Length + " has area: " + rectangleA.calculateArea() + "\t" + rectangleB.Color);
            Console.WriteLine(rectangleB.Name + "\t" + rectangleB.Width + "\t" + rectangleB.Length + " has area: " + rectangleB.calculateArea() + "\t" + rectangleB.Color);
            Console.WriteLine(rectangleC.Name + "\t" + rectangleC.Width + "\t" + rectangleC.Length + " has area: " + rectangleC.calculateArea() + "\t" + rectangleC.Color);
            Console.WriteLine();
            Console.WriteLine(squareA.Name + "\t" + squareA.Width + " has area: " + squareA.calculateArea() + "\t" + squareA.Color);
            Console.WriteLine(squareB.Name + "\t" + squareB.Width + " has area: " + squareB.calculateArea() + "\t" + squareB.Color);
            Console.WriteLine(squareC.Name + "\t" + squareC.Width + " has area: " + squareC.calculateArea() + "\t" + squareC.Color);
            Console.ReadLine();
        }
    }
}
