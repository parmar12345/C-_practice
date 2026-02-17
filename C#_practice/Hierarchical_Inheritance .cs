using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Hierarchical_Inheritance
    {
        // Base Class (Parent)
        public class Shape
        {
            public string Color { get; set; }

            public void DisplayColor()
            {
                Console.WriteLine("Color: " + Color);
            }

            public void Draw()
            {
                Console.WriteLine("Drawing a shape...");
            }
        }

        // Child Class 1
        public class Circle : Shape
        {
            public double Radius { get; set; }

            public void CalculateArea()
            {
                double area = 3.14 * Radius * Radius;
                Console.WriteLine("Circle Area: " + area);
            }

            public void CalculateCircumference()
            {
                double circumference = 2 * 3.14 * Radius;
                Console.WriteLine("Circle Circumference: " + circumference);
            }
        }

        // Child Class 2
        public class Rectangle : Shape
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public void CalculateArea()
            {
                double area = Length * Width;
                Console.WriteLine("Rectangle Area: " + area);
            }

            public void CalculatePerimeter()
            {
                double perimeter = 2 * (Length + Width);
                Console.WriteLine("Rectangle Perimeter: " + perimeter);
            }
        }

        // Child Class 3
        public class Triangle : Shape
        {
            public double Base { get; set; }
            public double Height { get; set; }

            public void CalculateArea()
            {
                double area = 0.5 * Base * Height;
                Console.WriteLine("Triangle Area: " + area);
            }
        }











        //// Create Circle object
        //Console.WriteLine("=== CIRCLE ===");
        //    Circle circle = new Circle();
        //circle.Color = "Red";
        //    circle.Radius = 5;
        //    circle.DisplayColor();      // From Shape
        //    circle.Draw();              // From Shape
        //    circle.CalculateArea();     // From Circle
        //    circle.CalculateCircumference();

        //    Console.WriteLine("\n=== TRIANGLE ===");
        //    // Create Triangle object
        //    Triangle triangle = new Triangle();
        //triangle.Color = "Green";
        //    triangle.Base = 8;
        //    triangle.Height = 6;
        //    triangle.DisplayColor();    // From Shape
        //    triangle.Draw();            // From Shape
        //    triangle.CalculateArea();   // From Triangle

        //    Console.WriteLine("\n=== RECTANGLE ===");
        //    // Create Rectangle object
        //    Rectangle rectangle = new Rectangle();
        //rectangle.Color = "Blue";
        //    rectangle.Length = 10;
        //    rectangle.Width = 5;
        //    rectangle.DisplayColor();   // From Shape
        //    rectangle.Draw();           // From Shape
        //    rectangle.CalculateArea();  // From Rectangle
        //    rectangle.CalculatePerimeter();
    }
}
