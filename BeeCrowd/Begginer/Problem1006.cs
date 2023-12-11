using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Classes.BeeCrowd.Begginer
{
    /// <summary>
    /// Average 2
    /// Read three values (variables A, B and C), which are the three student's grades. 
    /// Then, calculate the average, considering that grade A has weight 2, grade B has weight 3 and the grade C has weight 5. 
    /// Consider that each grade can go from 0 to 10.0, always with one decimal place.
    /// </summary>
    internal class Problem1006
    {
        static void Main()
        {
            double a;
            double b;
            double c;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (0.2 * a + 0.3 * b + 0.5 * c) / 1;

            Console.WriteLine($"MEDIA = {average:N1}");
        }
    }
}
