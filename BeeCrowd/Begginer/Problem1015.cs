using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Distance between two points
    /// Read the four values corresponding to the x and y axes of two points in the plane, p1 (x1, y1) and p2 (x2, y2) 
    /// and calculate the distance between them, showing four decimal places after the comma, according to the known formula
    /// </summary>
    internal class Problem1015
    {
        struct Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }    
        }

        static class Plane
        {
            public static double GetDistanceBetweenPoints(Point p1, Point p2)
            {
                double root = Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2);
                return Math.Sqrt(root);
            }
        }

        static void Main()
        {
            double x, y;
            string[] values = Console.ReadLine().Split();

            x = double.Parse(values[0], System.Globalization.CultureInfo.InvariantCulture);
            y = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);

            Point p1 = new Point(x, y);

            values = Console.ReadLine().Split();

            x = double.Parse(values[0], System.Globalization.CultureInfo.InvariantCulture);
            y = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);

            Point p2 = new Point(x, y);

            double distance = Plane.GetDistanceBetweenPoints(p1, p2);

            Console.WriteLine($"{distance.ToString("N4", System.Globalization.CultureInfo.InvariantCulture).Replace(",", "")}");
        }
    }
}
