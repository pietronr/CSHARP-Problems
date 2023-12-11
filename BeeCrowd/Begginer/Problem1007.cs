using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Difference
    /// Read four integer values named A, B, C and D. 
    /// Calculate and print the difference of product A and B by the product of C and D (A * B - C * D).
    /// </summary>
    internal class Problem1007
    {
        static void Main()
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            b = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            c = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            d = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            int dif = (a * b) - (c * d);

            Console.WriteLine($"DIFERENCA = {dif}");
        }
    }
}
