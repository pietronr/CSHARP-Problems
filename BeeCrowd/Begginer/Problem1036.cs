using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Bhaskara's Formula
    /// Read 3 floating-point numbers. After, print the roots of bhaskara’s formula. 
    /// If it's impossible to calculate the roots because a division by zero or a square root of a negative number, presents the message “Impossivel calcular”.
    /// </summary>
    static class Problem1036
    {
        static void Do(string[] args)
        {
            double a, b, c;

            string[] values = Console.ReadLine().Split();

            a = double.Parse(values[0], CultureInfo.InvariantCulture);
            b = double.Parse(values[1], CultureInfo.InvariantCulture);
            c = double.Parse(values[2], CultureInfo.InvariantCulture);

            double delta = b * b - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"R1 = {root1:N5}");
                Console.WriteLine($"R2 = {root2:N5}");
            }
        }
    }
}
