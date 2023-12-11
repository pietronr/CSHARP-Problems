using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Area of a circle
    /// The formula to calculate the area of a circumference is defined as A = π . R2. Considering to this problem that π = 3.14159:
    /// Calculate the area using the formula given in the problem description.
    /// </summary>
    internal class Problem1002
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double radius;

            radius = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double area = pi * (radius * radius);
            string stringArea = area.ToString("N4", System.Globalization.CultureInfo.InvariantCulture).Replace(",", "");

            Console.WriteLine($"A={stringArea}");
        }
    }
}
