using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Sphere
    /// Make a program that calculates and shows the volume of a sphere being provided the value of its radius (R) . 
    /// The formula to calculate the volume is: (4/3) * pi * R3. 
    /// Consider (assign) for pi the value 3.14159.
    /// Tip: Use(4/3.0) or(4.0/3) in your formula, because some languages(including C++) assume that the division's result between two integers is another integer. :)
    /// </summary>
    internal class Problem1011
    {
        static void Main()
        {
            const double pi = 3.14159;
            double radius;

            radius = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double volume = 4.0 / 3 * pi * Math.Pow(radius, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("N3", System.Globalization.CultureInfo.InvariantCulture).Replace(",", "")}");
        }
    }
}
