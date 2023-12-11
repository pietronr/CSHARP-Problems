using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Triangle Types
    /// Read 3 double numbers (A, B and C) representing the sides of a triangle and arrange them in decreasing order, so that the side A is the biggest of the three sides. 
    /// Next, determine the type of triangle that they can make.
    /// </summary>
    internal class Problem1045
    {
        static void Do()
        {
            double a, b, c;
            double auxA;

            string[] values = Console.ReadLine().Split();

            a = auxA = double.Parse(values[0], System.Globalization.CultureInfo.InvariantCulture);
            b = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
            c = double.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);

            if (b > a && b > c)
            {
                a = b;
                b = auxA;
            }
            else if (c > a && c > b)
            {
                a = c;
                c = auxA;
            }

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (a * a == (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (a * a > (b * b) + (c * c))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if ((a == b && b != c) || (a == c && b != c) || (b == c && c != a))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
