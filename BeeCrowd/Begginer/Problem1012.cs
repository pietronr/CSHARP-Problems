using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    static class ValueToStringExtensions
    {
        public static string ValueToString(this object value, string format)
        {
            if (value is double doubleValue)
            {
                return doubleValue.ToString(format, System.Globalization.CultureInfo.InvariantCulture).Replace(",", "");
            }
            else if (value is int intValue)
            {
                return intValue.ToString(format, System.Globalization.CultureInfo.InvariantCulture).Replace(",", "");

            }

            return "";
        }
    }

    /// <summary>
    /// Area
    /// Make a program that reads three floating point values: A, B and C. Then, calculate and show:
    /// a) the area of the rectangled triangle that has base A and height C.
    /// b) the area of the radius's circle C. (pi = 3.14159)
    /// c) the area of the trapezium which has A and B by base, and C by height.
    /// d) the area of ​​the square that has side B.
    /// e) the area of the rectangle that has sides A and B
    /// </summary>
    internal class Problem1012
    {
        interface IShape
        {
            double Area();
        }

        class Triangle : IShape
        {
            public Triangle(double height, double @base)
            {
                Height = height;
                Base = @base;
            }

            public double Height { get; }
            public double Base { get; }

            public double Area() => Height * Base / 2;
            public override string ToString() => $"TRIANGULO: {Area().ValueToString("N3")}";
        }

        class Circle : IShape
        {
            public Circle(double radius)
            {
                Radius = radius;
            }

            private const double pi = 3.14159;
            public double Radius { get; set; }

            public double Area() => pi * Math.Pow(Radius, 2);
            public override string ToString() => $"CIRCULO: {Area().ValueToString("N3")}";
        }

        class Trapezium : IShape
        {
            public Trapezium(double height, double largeBase, double smallBase)
            {
                Height = height;
                LargeBase = largeBase;
                SmallBase = smallBase;
            }

            public double Height { get; }
            public double LargeBase { get; }
            public double SmallBase { get; }

            public double Area() => (LargeBase + SmallBase) * Height / 2;
            public override string ToString() => $"TRAPEZIO: {Area().ValueToString("N3")}";
        }

        class Square : IShape
        {
            public Square(double side)
            {
                Side = side;
            }

            public double Side { get; set; }

            public double Area() => Math.Pow(Side, 2);
            public override string ToString() => $"QUADRADO: {Area().ValueToString("N3")}";
        }

        class Rectangle : IShape
        {
            public Rectangle(double smallerSide, double biggerSide)
            {
                SmallerSide = smallerSide;
                BiggerSide = biggerSide;
            }

            public double SmallerSide { get; set; }
            public double BiggerSide { get; set; }

            public double Area() => SmallerSide * BiggerSide;
            public override string ToString() => $"RETANGULO: {Area().ValueToString("N3")}";
        }

        static void Main()
        {
            double a, b, c;

            string[] values = Console.ReadLine().Split();

            a = double.Parse(values[0], System.Globalization.CultureInfo.InvariantCulture);
            b = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
            c = double.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);

            Triangle triangle = new Triangle(a, c);
            Circle circle = new Circle(c);
            Trapezium trapezium = new Trapezium(c, b, a);
            Square square = new Square(b);
            Rectangle rectangle = new Rectangle(a, b);

            Console.WriteLine(triangle.ToString());
            Console.WriteLine(circle.ToString());
            Console.WriteLine(trapezium.ToString());
            Console.WriteLine(square.ToString());
            Console.WriteLine(rectangle.ToString());
        }
    }
}
