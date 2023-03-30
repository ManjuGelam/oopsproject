using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
   
        public abstract class absexamplefigure
        {
            public const float Pi = 3.14f;
            public double Width, Height, Radius;
            public abstract double GetArea();
        }
           public class Cone : absexamplefigure
        {
            public Cone(double Height, double Radius)
            {
                this.Height = Height;
                base.Radius = Radius; //Here this and base are same
            }
              public override double GetArea()
            {
                return Pi * Radius * (Radius + Math.Sqrt((Height * Height) + (Radius * Radius)));
            }
        }
        public class Circle : absexamplefigure
        {
            public Circle(double Radius)
            {
                this.Radius = Radius;
            }
            public override double GetArea()
            {
                return Pi * Radius * Radius;
            }
        }
        public class Triangle : absexamplefigure
        {
            public Triangle(double Base, double Height)
            {
                this.Width = Base;
                this.Height = Height;
            }
            public override double GetArea()
            {
                return 0.5 * Width * Height;
            }
        }
        public class Rectangle : absexamplefigure
        {
            public Rectangle(double Length, double Breadth)
            {
                this.Width = Length;
                this.Height = Breadth;
            }
            public override double GetArea()
            {
                return Width * Height;
            }
        }
        internal class Testabsexamplefigure
        {
            static void Main()
            {
                Cone cone = new Cone(18.92, 34.12);
                Console.WriteLine($"Area of Cone is: {cone.GetArea()}\n");

                Circle circ = new Circle(45.36);
                Console.WriteLine($"Area of Circle is: {circ.GetArea()}\n");

                Triangle trin = new Triangle(34.98, 27.87);
                Console.WriteLine($"Area of Triangle is: {trin.GetArea()}\n");

                Rectangle rect = new Rectangle(45.29, 76.12);
                Console.WriteLine($"Area of Rectangle is: {rect.GetArea()}\n");

                Console.ReadLine();
            }
        }
    }



